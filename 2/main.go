package main

import (
	"bufio"
	"fmt"
	"log"
	"os"
)

func main() {
	file, err := os.Open("world.txt")
	if err != nil {
		log.Fatal(err)
	}
	defer file.Close()

	s := bufio.NewScanner(file)
	globalcount := 0
	for s.Scan() {
		curr := s.Text()
		count := 0
		started := false
		prev := rune(0)
		for _, char := range curr {
			if char == 32 && prev == 35 {
				started = true
			}
			if char == 35 && prev == 32 {
				started = false
				globalcount += count
				count = 0
			}
			if char == 32 && started {
				count++
			}
			prev = char
		}
	}

	fmt.Println(globalcount)

	if err := s.Err(); err != nil {
		log.Fatal(err)
	}
}
