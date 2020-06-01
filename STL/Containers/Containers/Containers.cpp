#include <iostream>
#include <vector>
#include <string>

using namespace std;

//vector starts
template <typename T>
void print_vector(vector< T > v, string s)
{
    cout << "Header : " << s << endl;
    cout << "Container Size : " << v.size() << endl;
    for (unsigned int i = 0; i < v.size(); i++)
    {
        cout << v[i] << " ";
    }
    cout << endl;
}

template <typename T>
void print_two_dimensional_vector(vector< vector<T> > v)
{
    for (unsigned int i = 0; i < v.size(); i++)
    {
        for (unsigned int j = 0; j < v[i].size(); j++)
        {
            cout << v[i][j] << " ";
        }
        cout << endl;
    }
}

void vector_processing()
{
    vector< int > v(10);
    print_vector(v, "Initial string");

    for (int i = 0; i < 10; i++) {
        v[i] = (i + 1) * (i + 1);
    }

    print_vector(v, "Positive operation");

    for (int i = 9; i > 0; i--) {
        v[i] -= v[i - 1];
    }

    print_vector(v, "Negative operation");

    //vector size operations

    int elements_count = v.size();

    bool is_nonempty_notgood = (v.size() >= 0); // Try to avoid this
    bool is_nonempty_ok = !v.empty(); //good

    //push_back

    for (int i = 1; i < 1000000; i *= 2) {
        v.push_back(i);
    }

    print_vector(v, "Push back operation");

    //resize

    v.resize(25);
    for (int i = 20; i < 25; i++) {
        v[i] = i * 2;
    }

    print_vector(v, "Resizing operation");

    //copy vector

    vector< int > v1;
    vector< int > v2 = v1;
    vector< int > v3(v1);

    // initializing string vector

    vector< string > names(20, "Unknown");

    print_vector(names, "String vector operation");

    //multidimensional vector

    int N, M;
    N = 3;
    M = 5;
    vector< vector< int > > Matrix(N, vector< int >(M, -1));

    print_two_dimensional_vector(Matrix);

}

//vector ends

int main()
{
    vector_processing();
}