package main

import (
	"flag"
	"fmt"
	"net"
)

var msg = flag.String("msg", "black", "use this to send some msg to the server")

func init() {
	flag.Parse()
}

func main() {
	fmt.Println(*msg)
	conn, err := net.Dial("tcp", "localhost:5000")
	if err != nil {
		fmt.Println(err)
		return
	}
	conn.Write([]byte(*msg))
	buff := make([]byte, 50)
	_, err = conn.Read(buff)
	if err != nil {
		fmt.Println(err)
		return
	}
	fmt.Println(string(buff))
}
