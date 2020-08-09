#include <iostream>
#include <bitset>

using namespace std;

int main()
{
    int S = 34;

    
    cout<<S<<"\n";
    
    //multiplication by 2
    //shift left
    S = S << 1;
    cout<<S<<"\n";

    //divide by 2
    //shift right
    S = S >> 1;
    cout<<S<<"\n"; 

    //turning on jth item 0 based indexing
    //use bitwise or operation

    S = 34; // 100010
    int j = 3;
    S |= (1 << j);

    cout<< S;    // 42 101010

    int T;
    // check if j-th item is set on
    // if T = 0 off
    //other wise on
    T = S & (1 << j);

    cout<< T<<endl;

    j = 0;

    T = S & (1 << j);

    cout<< j << endl;

    //clear or turn off the j-th item of the set

    j = 1;
    
    S &= ~(1 << j); // 101010 (42) AND (bit wise not operation) 111101

    cout<< S; // 101000

    // toggle or flip the j-th item

    S = 40; // 101000
    j = 2;

    S ^= (1 << j); //XOR Operation

    // get value of the least significant bit that is on


    T = (S & (-S)); // depending on the value of the T decide which one is on

    //turn on all bits size of n
    int n = 3;

    S = (1 << n) - 1;
}