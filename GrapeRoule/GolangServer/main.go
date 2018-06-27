package main

import (
	"fmt"
	"math/rand"
	"net"
	"strconv"
	"sync"
)

type Room struct {
	Conns []net.Conn
	sync.Mutex
	Ready bool
	Num   int
}

var nums = map[int]bool{
	1:  false,
	2:  true,
	3:  false,
	4:  true,
	5:  false,
	6:  true,
	7:  false,
	8:  true,
	9:  false,
	10: true,
	11: true,
	12: false,
	13: true,
	14: false,
	15: true,
	16: false,
	17: true,
	18: false,
	19: false,
	20: true,
	21: false,
	22: true,
	23: false,
	24: true,
	25: false,
	26: true,
	27: false,
	28: true,
	29: true,
	30: false,
	31: true,
	32: false,
	33: true,
	34: false,
	35: true,
	36: false,
}

func main() {
	l, err := net.Listen("tcp", "localhost:5000")
	if err != nil {
		fmt.Println(err)
		return
	}
	var r Room
	r.Ready = false
	r.Num = rand.Intn(37)
	defer l.Close()
	for {
		conn, err := l.Accept()
		if err != nil {
			fmt.Println(err)
			return
		}
		fmt.Println("connecting", len(r.Conns))
		if len(r.Conns) >= 2 && r.Ready == true {
			conn.Close()
		} else if len(r.Conns) < 2 {
			r.Conns = append(r.Conns, conn)
		}
		if len(r.Conns) == 2 && r.Ready == false {
			r.Ready = true
			go hanleRoom(r)
		}
		fmt.Printf("%+v \n", r)
	}
}

func hanleRoom(r Room) {
	fmt.Println("room is beein handled")
	ans := map[net.Conn]string{}
	for _, c := range r.Conns {
		buff := make([]byte, 50)
		c.Read(buff)
		fmt.Println(buff, string(buff))
		ans[c] = byteToStr(buff)
	}
	fmt.Println(r.Num)
	for c, a := range ans {
		fmt.Println(strconv.Itoa(r.Num), a, strconv.Itoa(r.Num) == a)
		if a == "even" && r.Num%2 == 0 && r.Num != 0 {
			c.Write([]byte("Right! the number is even"))
		} else if a == "even" && r.Num%2 != 0 {
			c.Write([]byte("Wrong! the number is odd"))
		}
		if a == "odd" {
			if r.Num%2 == 0 {
				c.Write([]byte("Wrong! the number is even"))
			} else if r.Num%2 != 0 {
				c.Write([]byte("Right! the number is odd"))
			}
		}
		if a == "red" {
			if nums[r.Num] == false {
				c.Write([]byte("Right! the number is red"))
			} else {
				c.Write([]byte("Wrong! the number is black"))
			}
		}
		if a == "black" {
			if nums[r.Num] == true {
				c.Write([]byte("Right! the number is black"))
			} else {
				c.Write([]byte("Wrong! the number is red"))
			}
		}
		if strconv.Itoa(r.Num) == a {
			c.Write([]byte("You guessed the number!"))
		} else {
			c.Write([]byte("You didn't guess the number"))
		}
	}
}

func byteToStr(b []byte) string {
	str := ""
	for _, v := range b {
		if v != byte(0) {
			str += string(v)
		}
	}
	return str
}
