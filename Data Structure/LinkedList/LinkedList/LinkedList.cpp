// LinkedList.cpp : Defines the entry point for the console application.
//

#include <iostream>
using namespace std;

struct Node
{
	int data;
	Node* next;
};
Node* Head;

void InsertInTheEnd(int value)
{
	Node* temp = Head;
	if (temp != NULL)
	{
		while (temp->next != NULL)
		{
			temp = temp->next;
		}
	}
	Node* temp1 = new Node();
	temp1->data = value;
	temp1->next = NULL;
	if (Head == NULL)
	{
		Head = temp1;
	}
	else
	{
		temp->next = temp1;
	}
}

void InsertInTheBeginning(int value)
{
	Node* temp1 = new Node();
	temp1->data = value;
	if (Head == NULL)
	{
		Head = temp1;
		temp1->next = NULL;
	}
	else
	{
		Node* temp = Head;
		Head = temp1;
		temp1->next = temp;
	}
}

void InsertValueAtnthPosition(int value, int position)
{
	if (Head != NULL)
	{
		//Node* start = Head;
		Node* temp = new Node();
		temp->data = value;
		Node* traverse = Head;
		int count = 1;
		while (count < position)
		{
			count++;
			traverse = traverse->next;
		}
		Node* temp1 = traverse;
		traverse->next = temp;
		temp->next = temp1->next;
	}
	else
	{
		cout << "The list is empty!" << endl;
	}
}

void TraverseTheLinkedList()
{
	if (Head != NULL)
	{
		Node* temp1 = Head;
		cout << temp1->data << endl;
		while (temp1->next != NULL)
		{
			temp1 = temp1->next;
			cout << temp1->data << endl;
		}
	}
	else
	{
		cout << "There's no element in the list" << endl;
	}
}

int main()
{
	Head = NULL;
	InsertInTheEnd(2);
	InsertInTheEnd(4);
	InsertInTheEnd(6);
	TraverseTheLinkedList();
	InsertValueAtnthPosition(5, 2);
	TraverseTheLinkedList();
    return 0;
}

