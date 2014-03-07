TITLE Program 					(main.asm)

;Elias Cole
;CS271
;Program 4

INCLUDE Irvine32.inc
MAXSIZE = 200
HIBOUND = 999
LOWBOUND = 100

.data

numArray	DWORD	MAXSIZE DUP(?)
userInput	DWORD	?

msgIntro BYTE "Name: Elias Cole  Program 4",0
msgOutro BYTE "Fin.",0
msgPrompt BYTE "Please enter the number of numbers you would like put into an array: ",0
msgLess10 BYTE "Your number is less than 10",0
msgMore200 BYTE "Your number is more than 200",0
msgMedian BYTE "The Median is: ",0




.code
main PROC  

call Intro

;get number of numbers to generate(10 - 200)
push OFFSET userInput
call GetUserInput

;Generate integers(100 - 999) and store them in the array
push OFFSET numArray
push userInput
call GenerateAndFill

;Display contents of array
push OFFSET numArray
push userInput
call DisplayArray

;Sort array
push OFFSET numArray
push userInput
call Sort

;Display contents of array
push OFFSET numArray
push userInput
call DisplayArray

;Calculate and display median
push OFFSET numArray
push userInput
call Median

call Outro

	exit
main ENDP


GetUserInput PROC
	push ebp
	mov ebp, esp
	
	startVal:
		mov edx,OFFSET msgPrompt  ;instructions for user
		call WriteString
		call crlf
		
		call ReadInt 	;get user input
		
		cmp eax, 10  ;jump if less than 1
		jl lessThan10
		
		cmp eax, 200	;jump if more than 100
		jg moreThan200
		
		jmp finishVal	;if valid, jump to end
		
	lessThan10: ;show error message, and repeat process
		mov edx,OFFSET msgLess10
		call WriteString
		call crlf
		call crlf
		jmp startVal
		
	moreThan200:  ;show error message and repeat process
		mov edx,OFFSET msgMore200
		call WriteString
		call crlf
		call crlf
		jmp startVal
			
	finishVal: ;prep for looping
		mov	ebx,[ebp+8]		;address of userInput into ebx
		mov	[ebx],eax		;user input value into userInput variable
	
	pop ebp
	ret 4
GetUserInput ENDP


GenerateAndFill PROC
	push ebp ;stackframe
	mov ebp, esp
	
	mov ecx,[ebp+8] ;user input
	mov edi,[ebp +12] ;address of array
	
	loop1:
		mov eax, HIBOUND ;getting random number
		sub eax, LOWBOUND
		inc eax
		call RandomRange
		add eax, LOWBOUND
		
		mov [edi], eax ;put the new number in the array
		add edi, 4
		loop loop1

	pop ebp
	ret 8
GenerateAndFill ENDP


Sort PROC
	push ebp
	mov ebp, esp
	mov ecx, [ebp+8]
	mov esi, [ebp+12]
	
	mov edx,0
	
	S0:
	mov	eax, edx			
	mov	edi, [esi+eax*4]	

	mov	ebx, edx			
S1:
	inc	ebx
	cmp	ebx, ecx			
	jge	S2

	cmp	edi, [esi+ebx*4]
	jge	S1				
	mov	eax, ebx		
	mov	edi, [esi+eax*4]
	jmp	S1
S2:
	
	push	[esi+eax*4]		
	mov	ebx, [esi+edx*4]	
	mov	[esi+eax*4], ebx	
	pop	[esi+edx*4]


	inc	edx				
	cmp	edx, ecx			
	jl	S0				

	pop	ebp				
	ret	8
Sort ENDP


DisplayArray PROC
	push ebp ;stackframe
	mov ebp, esp
	
	mov edx,[ebp+8] ;number of numbers
	mov esi,[ebp +12] ;address of array
	dec edx
	call crlf
	
	jump1: ;write out array values 
		mov eax, [esi+edx*4]
		call WriteDec
		call crlf
		
		dec edx
		cmp edx,0
		jge jump1
	
	call crlf
	call crlf
	
	pop ebp
	ret 8
DisplayArray ENDP


Median PROC
	push ebp ;stackframe
	mov ebp, esp
	
	mov edx,OFFSET msgMedian
	call WriteString
	call crlf
	
	mov edx,[ebp+8] ;number of numbers
	mov esi,[ebp +12] ;address of array
	
	mov eax, edx
	mov ebx, 2
	xor edx, edx
	div ebx
	cmp edx, 0
	
	JE UserInputEven
	
	
	UserInputOdd:
	mov ecx,[ebp+8] 
	dec ecx         
	
	mov eax, ecx 
	mov ebx, 2	 
	xor edx, edx 
	div ebx         
	
	mov eax, [esi+eax*4] ;Array[x]
	call WriteDec
	jmp Finish
	
	
	UserInputEven:
	mov eax,[ebp+8]     ;Example: 14    
	mov ebx, 2	 
	xor edx, edx 
	div ebx         ;14/2 = 7
	dec eax
	
	mov ecx, [esi+eax*4] ;save Array[7]
	
	mov eax,[ebp+8]        
	mov ebx, 2	 
	xor edx, edx 
	div ebx 
	add ecx, [esi+eax*4] ;x = Array[7] + Array[8]
	
	mov eax, ecx        
	mov ebx, 2	 
	xor edx, edx 
	div ebx ;x/2 = median
	
	call WriteDec
	mov	al,'.'
	call WriteChar
	mov eax, edx
	call WriteDec  ;writing out the remainder, getting .1 instead of .5
	
	Finish:
	call crlf
	pop ebp
	ret 8
Median ENDP


Intro PROC
	call Clrscr
	mov edx,OFFSET msgIntro
	call WriteString
	call crlf
	call Randomize
	
	ret
Intro ENDP

Outro PROC
	call crlf
	mov edx,OFFSET msgOutro
	call WriteString
	call crlf
	call crlf
	
	ret
Outro ENDP







END main