cd\
cd Modeltech_pe_edu_10.4a\examples
vlog Adder.v ALU.v clock.v Control.v Data_Memory.v IM.v Instruction_Register.v Jump.v MUX_2to1.v PC.v RF.v Sign_Extension.v SLL_Generic.v Top.v
vsim -c -do "run -all" mips