cd\
e:
cd Mips Project\MIPS-master\MIPS-master
vlog Adder.v ALU.v clock.v Control.v Data_Memory.v IM.v Instruction_Register.v Jump.v MUX_2to1.v PC.v RF.v Sign_Extension.v SLL_Generic.v Top.v
vsim -c -do "run -all" mips