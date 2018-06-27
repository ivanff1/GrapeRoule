package models

type FileData struct {
	Name string `json:"name"`
	Data string `json:"data"`
}

func NewFileData(name, data string) FileData {
	return FileData{Name: name, Data: data}
}
