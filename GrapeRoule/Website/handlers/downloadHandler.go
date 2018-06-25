package handlers

import (
	"net/http"
)

func DownloadAHandler(w http.ResponseWriter, r *http.Request) {

	http.ServeFile(w, r, "source/app-debug.apk")

}

func DownloadWHandler(w http.ResponseWriter, r *http.Request) {

	http.ServeFile(w, r, "source/Client.exe")
}
