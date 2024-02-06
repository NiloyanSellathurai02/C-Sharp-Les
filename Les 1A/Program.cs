// See https://aka.ms/new-console-template for more information

static void divideNumber(int a , int b ){
if(b == 0){
    Console.WriteLine("Undefined");
}else if (Math.Abs(b) < 1){
    Console.WriteLine("Small Divider:" + (a / b));
}else{
    int result = a /b ;
    string resultasString = result.ToString();
    Console.WriteLine("Result:" +resultasString);
}
} 

string globalNumber = "5";



divideNumber(10 , 5);