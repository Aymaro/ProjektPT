#!/usr/bin/env python
# -*- coding: utf8 -*-

import RPi.GPIO as GPIO
import MFRC522
import signal
import socket
import time

continue_reading = True

# Capture SIGINT for cleanup when the script is aborted
def end_read(signal,frame):
    global continue_reading
    print "Ctrl+C captured, ending read."
    continue_reading = False
    GPIO.cleanup()
	
TCP_IP = '192.168.0.101'
TCP_PORT = 13000

d = 29
slp = 33
#ledy
GPIO.setmode(GPIO.BOARD)
GPIO.setup(slp, GPIO.OUT)
GPIO.setup(d, GPIO.OUT)

#ledy inicjalizacja
GPIO.output(slp, 1)
GPIO.output(d, 0)

# Hook the SIGINT
signal.signal(signal.SIGINT, end_read)

# Create an object of the class MFRC522
MIFAREReader = MFRC522.MFRC522()

# Welcome message
print "Welcome to the MFRC522 data read example"
print "Press Ctrl-C to stop."

# This loop keeps checking for chips. If one is near it will get the UID and authenticate
while continue_reading:
    
    # Scan for cards    
    (status,TagType) = MIFAREReader.MFRC522_Request(MIFAREReader.PICC_REQIDL)

    # If a card is found
    if status == MIFAREReader.MI_OK:
        print "Card detected"
    
    # Get the UID of the card
    (status,uid) = MIFAREReader.MFRC522_Anticoll()

    # If we have the UID, continue
    if status == MIFAREReader.MI_OK:

        # Print UID
		UID = ""
		UID += str(hex(uid[0]))+str(hex(uid[1]))+str(hex(uid[2]))+str(hex(uid[3])) 
		
		print "Card read UID: "+str(hex(uid[0]))+","+str(hex(uid[1]))+","+str(hex(uid[2]))+","+str(hex(uid[3]))
		print "czas: " +str(int(time.time()))
		#wyslanie do serwera
		MESSAGE = ""
		MESSAGE += "001 " + UID + " " +str(int(time.time()))
		MSG = str.encode(MESSAGE)
		s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
		s.connect((TCP_IP, TCP_PORT))
		s.send(MSG)
		s.close()
		GPIO.output(d, 1)
		GPIO.output(slp, 0)
		time.sleep(0.5)
		GPIO.output(slp, 1)
		GPIO.output(d, 0)
