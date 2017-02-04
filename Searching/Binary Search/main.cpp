#include <iostream>
#include <vector>

using namespace std;

bool Binary_Seach(vector<T> &A, T target)
{
    int low = 0;
    int high = A.size();
    int mid;
    while(low<=high)
    {
        mid = low + (high - low)/2;
        if(A[mid] == target)
        {
            return true;
        }
        else if(A[mid] < target)
        {
            low = mid + 1;
        }
        else
        {

            high = mid - 1;
        }
    }
    return false;
}


int main()
{
    vector<int> newVector;
    for(int i=0; i < 100 ; i++)
    {
        newVector.push_back(i);
    }
    Binary_Seach(newVector, 56) ? cout<< "Found" : cout << "Not Found";
    Binary_Seach(newVector, 156) ? cout<< "Found" : cout << "Not Found";


    return 0;
}
