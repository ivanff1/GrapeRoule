package main

import (
	"fmt"
	"net/http"
	"os"
	"path/filepath"
	"regexp"
	"strings"

	"config"
)

var word *regexp.Regexp
var root string = config.GetDir()
var fileList []string
var rootParsed string

func init() {
	w, err := regexp.Compile(`\W`)
	if err != nil {
		fmt.Println("invalid dir", err)
		return
	}
	word = w
	rootParsed = word.ReplaceAllString(root, "")
	err = filepath.Walk(root, func(path string, f os.FileInfo, err error) error {
		if !f.IsDir() {
			p := filepath.ToSlash(path)
			fileList = append(fileList, p)
		}
		return nil
	})
	if err != nil {
		fmt.Println("error", err)
		return
	}
}

func indexHandler(w http.ResponseWriter, r *http.Request) {
	for _, v := range fileList {
		path := v[len(rootParsed)+1:]
		if strings.Contains(r.URL.Path, path) {
			http.ServeFile(w, r, v)
			return
		}
	}
	http.ServeFile(w, r, root+"/index.html")
}

func cors(m http.Handler) http.Handler {
	return http.HandlerFunc(func(w http.ResponseWriter, r *http.Request) {
		w.Header().Set("Access-Control-Allow-Origin", "*")
		m.ServeHTTP(w, r)
	})
}
