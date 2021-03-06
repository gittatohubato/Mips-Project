
module resfile(read1,read2,writereg,writedata,write,data1,data2,data2_mem,clk);
input[4:0]read1,read2,writereg;
input[31:0]writedata;
input write,clk;
reg[31:0]rf[0:31];
output  [31:0] data1,data2, data2_mem; 

integer i;
integer file ;


initial
begin
i=0;
rf[0] = 10 ;  // rs
rf[1] <=20 ;  // rt 
rf[2]<= 45 ; 
rf[3]<= 10;
rf[4]<=6 ; //$zero 
end

assign read1 = 0;
assign read2 = 0;

always@(posedge clk)
 begin

if(read1===5'b00000 && read2===5'b00000)
begin
file = $fopen("C:\\Users\\Mohamed Amr\\Desktop\\rf.txt","w");
for (i = 0; i<32; i=i+1)
begin
//@(posedge clk);
$display("rf =%d",rf[i]);
$fwrite(file,"%b\n",rf[i]);
end
$fclose(file);  
end
else if (write)
rf[writereg]<=writedata;

end
endmodule



module registerFileTestBench();


reg[4:0]read1,read2,writereg;
reg[31:0]writedata;
reg write,clk;
wire  [31:0] data1,data2, data2_mem; 

initial
begin
read1 = 0; 
read2 = 0;
end

resfile hello(read1,read2,writereg,writedata,write,data1,data2,data2_mem,clk);

endmodule
