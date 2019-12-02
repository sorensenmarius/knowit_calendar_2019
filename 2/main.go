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
		prev := 0
		for _, char := range curr {
			thischar := int(char)
			if thischar == 32 && prev == 35 {
				started = true
			}
			if thischar == 35 && prev == 32 {
				started = false
				globalcount += count
				count = 0
			}
			if thischar == 32 && started {
				count++
			}
			prev = thischar
		}
	}

	fmt.Println(globalcount)

	if err := s.Err(); err != nil {
		log.Fatal(err)
	}
}
