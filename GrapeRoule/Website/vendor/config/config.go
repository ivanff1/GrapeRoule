package config

import (
	"encoding/json"
	"io/ioutil"
	"log"
)

type config struct {
	Dir     string `json:"dir"`
	Author  string `json:"username"`
	Version string `json:"version"`
	DBURL   string `json:"db_url"`
	DB      string `json:"db"`
	CORS    string `json:"CORS_Allowed_Origins"`
}

var c config

func init() {
	data, err := ioutil.ReadFile("magconfig.json")
	if err != nil {
		log.Fatalln(err)
	}
	err = json.Unmarshal(data, &c)
	if err != nil {
		log.Fatalln(err)
	}
}
func GetOrigins() string {
	return c.CORS
}

//GetDir returns the directory of the angular build files
func GetDir() string {
	return c.Dir
}

//GetAuthor returns the name of the author of the project
func GetAuthor() string {
	return c.Author
}

//GetVerion returns the version of the project
func GetVerion() string {
	return c.Version
}

//GetDBURL returns the url of the mongodb db
func GetDBURL() string {
	return c.DBURL
}

//GetDB return the name of mongodb db
func GetDB() string {
	return c.DB
}
