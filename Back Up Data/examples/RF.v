module resfile(read1,read2,writereg,writedata,write,data1,data2,data2_mem,clk);
input[4:0]read1,read2,writereg;
input[31:0]writedata;
input write,clk;
reg[31:0]rf[0:31];
output [31:0] data1,data2, data2_mem; 
integer file ;
integer i;

initial
begin
rf[0] <= 0 ;  // $zero = 0
end
/////////////////////
assign data1 = rf[read1];
assign data2 = rf[read2];
assign data2_mem = data2;

always@(posedge clk)
begin

if (write)
rf[writereg]<=writedata;

file = $fopen("C:\\Modeltech_pe_edu_10.4a\\examples\\TEXT FILE OF OUTPUTS\\Register Output Data .txt","w");
for (i = 0; i<32; i=i+1)
begin
$fwrite(file,"%b\n",rf[i]);
end
$fclose(file);
end

endmodule

