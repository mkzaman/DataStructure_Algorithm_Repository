// LinkedList.cpp : Defines the entry point for the console application.
//

#include <iostream>
using namespace std;

struct Node
{
	int data;
	Node* next;
};


void InsertInTheEnd(Node *Head,int value)
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

void InsertInTheBeginning(Node *Head, int value)
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

void InsertValueAtnthPosition(Node *Head, int value, int position)
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

void TraverseTheLinkedList(Node *Head)
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

void DeleteAtnthPosition(Node *Head, int position)
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

void TraverseUsingRecursion(Node *Head)
{
	if (Head == NULL)
	{
		return;
	}
	cout << Head->data << endl;
	TraverseUsingRecursion(Head->next);
}

void PrintBackWard(Node *Head)
{
	if (Head == NULL)
	{
		return;
	}
	PrintBackWard(Head->next);
	cout << Head->data << endl;
}

int main()
{
	Node* Head = NULL;
	InsertInTheEnd(Head, 2);
	InsertInTheEnd(Head, 4);
	InsertInTheEnd(Head, 6);
	TraverseTheLinkedList(Head);
	DeleteAtnthPosition(Head, 2);
	cout << "After Delete at position 2 : " << endl;
	TraverseTheLinkedList(Head);
	DeleteAtnthPosition(Head, 1);
	cout << "After Delete at position 1 : " << endl;
	TraverseTheLinkedList(Head);
    return 0;
}