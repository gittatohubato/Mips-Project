module program_counter (clk, pcin, pcout,pcout4);

input  clk;
input [31:0] pcin;
output reg [31:0] pcout;
output reg [31:0] pcout4; 
integer flag = 0 ;        
  always @(posedge clk)
      begin
if (! flag)
begin
pcout = 0 ;
flag <= 1 ;
pcout4 <= pcout + 4;
end 
       
else if(pcin < 4*8192) 
begin 
pcout <= pcin;
pcout4 <= pcin + 4;
end

else
begin
$stop;
//$finish ;
$monitor ("h555h");
end

end



endmodule


