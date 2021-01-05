module TBquestion();
/*reg [3:0] a;
reg [3:0] b;
reg [3:0] c;
reg[2:0] d;
initial begin
$monitor("%d",d);
#5 if (c===4'bxxxx) begin d=4; end else begin d=5; end #5 d=1; end*/

//d = (c==4'bxxxx)? 4:5; end

/*wire c;reg a,b;
initial fork
$monitor($time , " : %b %b %b",a,b,c);
a <= 0; b <= 1;
#5 a <= 1; b <= 0;
#10 a <= 0; b <= 1;
#15 a <= 1; b <= 1;
join
and meAnd(c,a,b);*/

reg d , clk;

initial
fork
#10
$monitor($time , " : %b",d);
#11
clk=0; 
#6
d=0;
join

always begin clk =! clk; #5; end 
always @(posedge clk)
begin d=1; end

endmodule
