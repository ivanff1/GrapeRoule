package models

type BasicRes struct {
	Success bool   `json:"success"`
	Msg     string `json:"message"`
}

func NewBasicRes(success bool, msg string) BasicRes {
	return BasicRes{Success: success, Msg: msg}
}
