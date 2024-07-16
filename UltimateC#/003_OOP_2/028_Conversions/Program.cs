decimal a = 10.01m;


//double is less precise then decimal, but much faster.
double b = 10.01;



// implicit conversion can only happen if conversion from one type to other is safe and lossless
int integer = 10;
decimal dec = integer;



decimal d = 10.01m;
//int i = d; // can not store a decimal in int, it will be lossy conversion (not lossless)
int i = (int)d; //explicit conversion




