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
		if (position < 2)
		{
			cout << "Please insert at the beginning!" <<endl;
			return;
		}
		Node* temp = new Node();
		temp->data = value;
		Node* traverse = Head;
		int count = 2;
		while (count < position)
		{
			count++;
			if (traverse == NULL)
			{
				cout << "Insert option is out of range!" << endl;
				return;
			}
			traverse = traverse->next;
		}
		Node* temp1 = traverse->next;
		temp->next = temp1;
		traverse->next = temp;
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

void DeleteAtnthPosition(int position)
{
	if (Head == NULL)
	{
		cout << "No element in the list" << endl;
		return;
	}
	if (position == 1)
	{
		Head = Head->next;
	}
	else
	{
		Node* current = Head;
		int count = 1;
		while (count < position)
		{
			if (current == NULL)
			{
				cout << "Out of range request" << endl;
			}
			count++;
			Node* previous = current;
			current = current->next;
			if (count == position)
			{
				previous->next = current->next;
				return;
			}
		}
	}
}

void ReverseLinkedList()
{
	if (Head == NULL)
	{
		cout << "The list is Empty" << endl;
		return;
	}
	Node *current, *previous, *next;
	current = Head;
	previous = NULL;
	while (current != NULL)
	{
		next = current->next;
		current->next = previous;
		previous = current;
		current = next;
	}
	Head = previous;
}

int main()
{
	Head = NULL;
	InsertInTheEnd(2);
	InsertInTheEnd(4);
	InsertInTheEnd(6);
	TraverseTheLinkedList();
	ReverseLinkedList();
	DeleteAtnthPosition(2);
	cout << "After Delete at position 2 : " << endl;
	TraverseTheLinkedList();
	DeleteAtnthPosition(1);
	cout << "After Delete at position 1 : " << endl;
	TraverseTheLinkedList();
    return 0;
}