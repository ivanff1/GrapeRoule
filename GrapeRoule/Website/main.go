package main

import (
	// "fmt"
	"net/http"
	"os"

	"github.com/gorilla/mux"
	"github.com/kinghunter58/fest-softuni/handlers"
)

var PORT = os.Getenv("PORT")

func main() {

	r := mux.NewRouter()
	api := r.PathPrefix("/api").Subrouter()
	api.Path("/downloadAndroid").HandlerFunc(handlers.DownloadAHandler)
	api.Path("/downloadWindows").HandlerFunc(handlers.DownloadWHandler)

	r.PathPrefix("/").HandlerFunc(indexHandler)
	http.ListenAndServe(":"+PORT, cors(r))

}

func init() {
	if PORT == "" {
		PORT = "3000"
	}
}
