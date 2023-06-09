﻿using DSA.DivideConquer;
using DSA.Dynamic;
using DSA.Graph;
using DSA.Greedy;
using DSA.MinimumSpanningTree;
using DSA.ShortestPath;
using DSA.Sorting;
using DSA.Trie;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

//
//        5
//     0 --- 1
// 15/ |   / |
//  4  |13/1 |8
// 20\ | /   |
//     2 --- 3
//        6
//

//PrimsAdjacencyMatrix primsAdjacencyMatrix = new PrimsAdjacencyMatrix(5);
//primsAdjacencyMatrix.AddEdge(0, 1, 5);
//primsAdjacencyMatrix.AddEdge(0, 2, 13);
//primsAdjacencyMatrix.AddEdge(0, 4, 15);
//primsAdjacencyMatrix.AddEdge(1, 2, 1);
//primsAdjacencyMatrix.AddEdge(1, 3, 8);
//primsAdjacencyMatrix.AddEdge(2, 3, 6);
//primsAdjacencyMatrix.AddEdge(2, 4, 20);
//primsAdjacencyMatrix.MST();

//PrimsAdjacencyList primsAdjacencyList = new PrimsAdjacencyList(5);
//primsAdjacencyList.AddEdge(0, 1, 5);
//primsAdjacencyList.AddEdge(0, 2, 13);
//primsAdjacencyList.AddEdge(0, 4, 15);
//primsAdjacencyList.AddEdge(1, 2, 1);
//primsAdjacencyList.AddEdge(1, 3, 8);
//primsAdjacencyList.AddEdge(2, 3, 6);
//primsAdjacencyList.AddEdge(2, 4, 20);
//primsAdjacencyList.MST();

//KruskalAdjacencyMatrix kruskalAdjacencyMatrix = new KruskalAdjacencyMatrix(5);
//kruskalAdjacencyMatrix.AddEdge(0, 1, 5);
//kruskalAdjacencyMatrix.AddEdge(0, 2, 13);
//kruskalAdjacencyMatrix.AddEdge(0, 4, 15);
//kruskalAdjacencyMatrix.AddEdge(1, 2, 1);
//kruskalAdjacencyMatrix.AddEdge(1, 3, 8);
//kruskalAdjacencyMatrix.AddEdge(2, 3, 6);
//kruskalAdjacencyMatrix.AddEdge(2, 4, 20);
//kruskalAdjacencyMatrix.MST();

//KruskalAdjacencyList kruskalAdjacencyList = new KruskalAdjacencyList(5);
//kruskalAdjacencyList.AddEdge(0, 1, 5);
//kruskalAdjacencyList.AddEdge(0, 2, 13);
//kruskalAdjacencyList.AddEdge(0, 4, 15);
//kruskalAdjacencyList.AddEdge(1, 2, 1);
//kruskalAdjacencyList.AddEdge(1, 3, 8);
//kruskalAdjacencyList.AddEdge(2, 3, 6);
//kruskalAdjacencyList.AddEdge(2, 4, 20);
//kruskalAdjacencyList.MST();

//HouseRobber houseRobber = new HouseRobber();
//Console.WriteLine(houseRobber.MaxMoneyTopDown(new int[] { 6, 7, 1, 30, 8, 2, 4 }));
//Console.WriteLine(houseRobber.MaxMoneyBottomUp(new int[] { 6, 7, 1, 30, 8, 2, 4 }));

//DivideConquer divideConquer = new DivideConquer();
//Console.WriteLine(divideConquer.NumberFactor(5));
//divideConquer.HouseRobber(new int[] {6,7,1,30,8,2,4 });
//divideConquer.ConvertOneStringToAnother("table", "tbres");
//int[] profile = { 31, 26, 17, 72 };
//int[] weight = { 3, 1, 2, 5 };
//divideConquer.ZeroOneKnapsack(profile, weight, 7);
//divideConquer.LongestCommonSubsequence("elephant", "erepats");
//divideConquer.LongestPalindromicSubsequence("elrmenmets");
//int[,] arr =
//{
//    {4,7,1,6 },
//    {5,7,3,9 }, 
//    {3,2,1,2 }, 
//    {7,1,6,3 }, 
//};
//Console.WriteLine(divideConquer.MinCostToReachLastCell(arr, arr.GetLength(0) - 1, arr.GetLength(1) - 1));
//Console.WriteLine(divideConquer.NumberOfPathsToReachLastCell(arr, arr.GetLength(0) - 1, arr.GetLength(1) - 1, 25));

//Item[] items = new Item[]
//        {
//            new Item(10, 60),
//            new Item(20, 100),
//            new Item(30, 120)
//        };

//DSA.Greedy.Greedy.FractionalKnapsack(items, 50);

//int[] arr = { 1, 2, 5, 10, 20, 50, 100, 1000 };
//DSA.Greedy.Greedy.CoinChangeProblem(arr, 2039);


//     0     1
//     |  /  |
//     2     3
//     |     |
//     4     |
//   /   \   |
//  7     5 --- 6

//TopologicalSortAdjacencyMatrix topologicalSortAdjacencyMatrix = new TopologicalSortAdjacencyMatrix(8);
//topologicalSortAdjacencyMatrix.AddEdge(0, 2);
//topologicalSortAdjacencyMatrix.AddEdge(2, 4);
//topologicalSortAdjacencyMatrix.AddEdge(4, 7);
//topologicalSortAdjacencyMatrix.AddEdge(4, 5);
//topologicalSortAdjacencyMatrix.AddEdge(5, 6);
//topologicalSortAdjacencyMatrix.AddEdge(1, 2);
//topologicalSortAdjacencyMatrix.AddEdge(1, 3);
//topologicalSortAdjacencyMatrix.AddEdge(3, 5);
//topologicalSortAdjacencyMatrix.Sort();


//TopologicalSortAdjacencyList topologicalSortAdjacencyList = new TopologicalSortAdjacencyList(8);
//topologicalSortAdjacencyList.AddEdge(0, 2);
//topologicalSortAdjacencyList.AddEdge(2, 4);
//topologicalSortAdjacencyList.AddEdge(4, 7);
//topologicalSortAdjacencyList.AddEdge(4, 5);
//topologicalSortAdjacencyList.AddEdge(5, 6);
//topologicalSortAdjacencyList.AddEdge(1, 2);
//topologicalSortAdjacencyList.AddEdge(1, 3);
//topologicalSortAdjacencyList.AddEdge(3, 5);
//topologicalSortAdjacencyList.Sort();

////
//// 0,1,2,3,4,5,6,7
//// A,B,C,D,E,F,G,H
////
///

int i = int.MaxValue;
int[,] graph = {
            {0, 5, i, 10},
            {i, 0, 3, i},
            {i, i, 0, 1},
            {i, i, i, 0}
        };

FloydWarshallAdjacencyMatrix floydWarshallAdjacencyMatrix = new FloydWarshallAdjacencyMatrix();
floydWarshallAdjacencyMatrix.ShortestPath(graph, 4);

//BellmanFordAdjacencyMatrix bellmanFordAM = new BellmanFordAdjacencyMatrix(5);
//bellmanFordAM.AddEdge(0, 1, -1);
//bellmanFordAM.AddEdge(0, 2, 4);
//bellmanFordAM.AddEdge(1, 2, 3);
//bellmanFordAM.AddEdge(1, 3, 2);
//bellmanFordAM.AddEdge(1, 4, 2);
//bellmanFordAM.AddEdge(3, 2, 5);
//bellmanFordAM.AddEdge(3, 1, 1);
//bellmanFordAM.AddEdge(4, 3, -3);
//bellmanFordAM.FindShortestPath(0);

//BellmanFordAdjacencyList bellmanFordAL = new BellmanFordAdjacencyList(5, 8);
//bellmanFordAL.AddEdge(0, 1, -1, 0);
//bellmanFordAL.AddEdge(0, 2, 4, 1);
//bellmanFordAL.AddEdge(1, 2, 3, 2);
//bellmanFordAL.AddEdge(1, 3, 2, 3);
//bellmanFordAL.AddEdge(1, 4, 2, 4);
//bellmanFordAL.AddEdge(3, 2, 5, 5);
//bellmanFordAL.AddEdge(3, 1, 1, 6);
//bellmanFordAL.AddEdge(4, 3, -3, 7);
//bellmanFordAL.FindShortestPath(3);

//DSA.ShortestPath.DijkstraAdjacencyMatrix dijkstra = new DijkstraAdjacencyMatrix();
//int[,] arrMat = {
//            { 0, 2, 0, 8, 0, 0 },
//            { 0, 0, 0, 5, 6, 0 },
//            { 0, 0, 0, 0, 0, 0 },
//            { 0, 0, 0, 0, 3, 2 },
//            { 0, 0, 9, 0, 0, 1 },
//            { 0, 0, 3, 0, 0, 0 }
//        };
//dijkstra.FindShortestPath(arrMat, 0);

//DSA.ShortestPath.DijkstraAdjacencyList dijkstra = new DijkstraAdjacencyList(6);
//dijkstra.AddEdge(0, 1, 2);
//dijkstra.AddEdge(0, 3, 8);
//dijkstra.AddEdge(1, 3, 5);
//dijkstra.AddEdge(1, 4, 6);
//dijkstra.AddEdge(3, 4, 3);
//dijkstra.AddEdge(3, 5, 2);
//dijkstra.AddEdge(4, 2, 9);
//dijkstra.AddEdge(4, 5, 1);
//dijkstra.AddEdge(5, 2, 3);
//dijkstra.FindShortestPath(0);

//int[] arr2 = { 23, 345, 5467, 12, 2345, 9852 };
//RadixSort.Sort(arr2).ToList().ForEach(c => { Console.Write(c + " - "); });

//int[] arr1 = { 4, 2, 6, 5, 1, 3, 8, 2, 7 };
//MergeSort.Sort(arr1).ToList().ForEach(c => { Console.Write(c + " - "); });
//QuickSort.Sort(arr1);
//HeapSort.Sort(arr1);

//int[] arr = { 4, 2, 6, 5, 1, 3, 8, 2, 7 };
//DSA.Sorting.Sort sort = new DSA.Sorting.Sort();
//sort.Bubble(arr);
//sort.Selection(arr);
//sort.Insertion(arr);
//sort.Bucket(arr, 3);

//GraphAdjacencyMatrix graphAdjacencyMatrix = new GraphAdjacencyMatrix(7);
//graphAdjacencyMatrix.AddEdge(0, 1);
//graphAdjacencyMatrix.AddEdge(0, 2);
//graphAdjacencyMatrix.AddEdge(1, 3);
//graphAdjacencyMatrix.AddEdge(2, 4);
//graphAdjacencyMatrix.AddEdge(3, 4);
//graphAdjacencyMatrix.AddEdge(3, 6);
//graphAdjacencyMatrix.AddEdge(3, 5);
//graphAdjacencyMatrix.AddEdge(4, 6);
//graphAdjacencyMatrix.AddEdge(5, 6);

//graphAdjacencyMatrix.DisplayMatrix();
//graphAdjacencyMatrix.BFS(4);
//graphAdjacencyMatrix.DFS(4);

//graphAdjacencyMatrix.RemoveEdge(3, 4);
//graphAdjacencyMatrix.DisplayMatrix();

//
//  { "0", "1", "2", "3", "4", "5", "6" };
//  { "A", "B", "C", "D", "E", "F", "G" };  
//
//          A
//        /   \
//       B     C
//       |     |
//       D --- E
//        \  \ |
//         F - G
//

//GraphAdjacencyList graphAdjacencyList = new GraphAdjacencyList();
//graphAdjacencyList.AddVertex("A");
//graphAdjacencyList.AddVertex("B");
//graphAdjacencyList.AddVertex("C");
//graphAdjacencyList.AddVertex("D");
//graphAdjacencyList.AddVertex("E");
//graphAdjacencyList.AddVertex("F");
//graphAdjacencyList.AddVertex("G");

//graphAdjacencyList.AddEdge("A", "B");
//graphAdjacencyList.AddEdge("A", "C");
//graphAdjacencyList.AddEdge("B", "D");
//graphAdjacencyList.AddEdge("C", "E");
//graphAdjacencyList.AddEdge("D", "E");
//graphAdjacencyList.AddEdge("D", "G");
//graphAdjacencyList.AddEdge("D", "F");
//graphAdjacencyList.AddEdge("E", "G");
//graphAdjacencyList.AddEdge("F", "G");

//Console.WriteLine(JsonSerializer.Serialize(graphAdjacencyList.AdjacencyList, new JsonSerializerOptions { WriteIndented = true }));

//graphAdjacencyList.BFS("A");
//graphAdjacencyList.BFS("E");

//graphAdjacencyList.DFSRecursive("A");
//graphAdjacencyList.DFSRecursive("E");

//graphAdjacencyList.RemoveVertex("D");
//Console.WriteLine(JsonSerializer.Serialize(graphAdjacencyList.AdjacencyList, new JsonSerializerOptions { WriteIndented = true }));

//graphAdjacencyList.DFSIterative("A");
//graphAdjacencyList.DFSIterative("E");


//DSA.Search.BinarySearch binarySearch = new DSA.Search.BinarySearch();
//Console.WriteLine(binarySearch.SearchArray(new int[] { 2,4,8,15,26,37,48,50,60,62,65,88 }, 7));
//Console.WriteLine(binarySearch.SearchArray(new int[] { 2, 4, 8, 15, 26, 37, 48, 50, 60, 62, 65, 88 }, 65));
//Console.WriteLine(binarySearch.SearchString("Fear leads to anger, conflict leads to suffering", "eads"));
//Console.WriteLine(binarySearch.SearchString("Fear leads to anger, hatred leads to conflict", "a"));
//Console.WriteLine(binarySearch.SearchString("Fear leads to anger, hatred leads to conflict", "hatred"));

//DSA.Trie.Trie trie = new DSA.Trie.Trie();
//trie.Add("anish");
//trie.Add("effie");
//trie.Add("america");
//trie.Add("griffina");
//trie.Add("anitha");
//trie.Add("ani");
//Console.WriteLine(trie.Search("ani"));
//Console.WriteLine(trie.Search("anit"));
//Console.WriteLine(trie.Search("anitha"));
//Console.WriteLine(trie.Search("amita"));
//Console.WriteLine(trie.Search("america"));
//Console.WriteLine(trie.Search("anidh"));
//Console.WriteLine(trie.Search("gri"));
//trie.Delete("an");
//trie.Delete("anish");
//trie.Delete("effie");
//Console.WriteLine(JsonSerializer.Serialize(trie.Root, new JsonSerializerOptions { WriteIndented = true }));

//DSA.HashTable.DoubleHash doubleHash = new DSA.HashTable.DoubleHash(20);
//doubleHash.Set("aaa", 20);
//doubleHash.Set("aab", 85);
//doubleHash.Set("abb", 23);
//doubleHash.Set("bbb", 45);
//doubleHash.Set("bbc", 98);
//doubleHash.Set("ff", 10);
//doubleHash.Set("gg", 28);
//doubleHash.Set("hh", 64);
//doubleHash.Set("ii", 09);
//doubleHash.Set("jj", 45);
//doubleHash.Set("kk", 76);
//Console.WriteLine(doubleHash.Get("abb"));
//Console.WriteLine(doubleHash.Get("jj"));
//doubleHash.List();

//DSA.HashTable.QuadraticHash quadraticHash = new DSA.HashTable.QuadraticHash(20);
//quadraticHash.Set("aaa", 20);
//quadraticHash.Set("aab", 85);
//quadraticHash.Set("abb", 23);
//quadraticHash.Set("bbb", 45);
//quadraticHash.Set("bbc", 98);
//quadraticHash.Set("ff", 10);
//quadraticHash.Set("gg", 28);
//quadraticHash.Set("hh", 64);
//quadraticHash.Set("ii", 09);
//quadraticHash.Set("jj", 45);
//quadraticHash.Set("kk", 76);
//Console.WriteLine(quadraticHash.Get("abb"));
//Console.WriteLine(quadraticHash.Get("jj"));
//quadraticHash.List();

//DSA.HashTable.LinearHash linearHash = new DSA.HashTable.LinearHash(11);
//linearHash.Set("aaa", 20);
//linearHash.Set("aab", 85);
//linearHash.Set("abb", 23);
//linearHash.Set("bbb", 45);
//linearHash.Set("bbc", 98);
//linearHash.Set("ff", 10);
//linearHash.Set("gg", 28);
//linearHash.Set("hh", 64);
//linearHash.Set("ii", 09);
//linearHash.Set("jj", 45);
//linearHash.Set("kk", 76);
//Console.WriteLine(linearHash.Get("abb"));
//Console.WriteLine(linearHash.Get("ff"));
//linearHash.List();

//DSA.HashTable.ChainingHash hashTable = new DSA.HashTable.ChainingHash(5);
//hashTable.Set("aaa", 20);
//hashTable.Set("aab", 85);
//hashTable.Set("abb", 23);
//hashTable.Set("bbb", 45);
//hashTable.Set("bbc", 98);
//hashTable.Set("ff", 10);
//hashTable.Set("gg", 28);
//hashTable.Set("gg", 64);
//hashTable.Set("ii", 09);
//hashTable.Set("jj", 45);
//hashTable.Set("kk", 76);
//Console.WriteLine(hashTable.Get("aab"));
//Console.WriteLine(hashTable.Get("kk"));
//hashTable.List().ForEach(c => { Console.Write(c + " - "); });
//Console.WriteLine(JsonSerializer.Serialize(hashTable.ListMap, new JsonSerializerOptions { WriteIndented = true }));

//DSA.BinaryHeap.BinaryHeap binaryHeap = new DSA.BinaryHeap.BinaryHeap(15);
//binaryHeap.Push(50);
//binaryHeap.Push(20);
//binaryHeap.Push(80);
//binaryHeap.Push(10);
//binaryHeap.Push(15);
//binaryHeap.Push(95);
//binaryHeap.Push(70);
//binaryHeap.Push(98);
//binaryHeap.Push(88);
//binaryHeap.Traverse();
//Console.WriteLine(binaryHeap.Pop());
//binaryHeap.Traverse();

//               50
//        20           80
//    10      15   95       70
//98      88


//               98
//        95           80
//    88      15   50       70
//10      20


//DSA.Tree.BinarySearchTree binarySearchTree = new DSA.Tree.BinarySearchTree();
//binarySearchTree.RInsert(100);
//binarySearchTree.RInsert(50);
//binarySearchTree.RInsert(150);
//binarySearchTree.RInsert(39);
//binarySearchTree.RInsert(69);
//binarySearchTree.RInsert(139);
//binarySearchTree.RInsert(169);
//binarySearchTree.RInsert(128);
//binarySearchTree.RInsert(117);
//binarySearchTree.RInsert(137);
//binarySearchTree.RInsert(17);

//binarySearchTree.TraverseNode();
//binarySearchTree.BreadthFirstSearch();
//binarySearchTree.DepthFirstSearch();

//Console.WriteLine(binarySearchTree.RContains(50));
//Console.WriteLine(binarySearchTree.RContains(139));
//Console.WriteLine(binarySearchTree.RContains(11));
//Console.WriteLine(binarySearchTree.MinNode(binarySearchTree.Root));
//Console.WriteLine(binarySearchTree.MinNode(binarySearchTree.Root.Left));
//Console.WriteLine(binarySearchTree.MinNode(binarySearchTree.Root.Right));

//Console.WriteLine(JsonSerializer.Serialize(binarySearchTree.Root, new JsonSerializerOptions { WriteIndented = true }));

//binarySearchTree.DeleteNode(binarySearchTree.Root, 169);
//binarySearchTree.DeleteNode(binarySearchTree.Root, 39);
//binarySearchTree.DeleteNode(binarySearchTree.Root, 128);
//binarySearchTree.DeleteNode(binarySearchTree.Root, 139);
//binarySearchTree.DeleteNode(binarySearchTree.Root, 112);

//DSA.StackQueue.QueueLinkedList queueLinkedList = new DSA.StackQueue.QueueLinkedList(100);
//queueLinkedList.Enqueue(200);
//queueLinkedList.Enqueue(300);
//Console.WriteLine(queueLinkedList.LastNode());
//queueLinkedList.Enqueue(400);
//queueLinkedList.Dequeue();
//queueLinkedList.Enqueue(500);
//queueLinkedList.Enqueue(600);
//queueLinkedList.Dequeue();
//Console.WriteLine(queueLinkedList.FirstNode());
//queueLinkedList.Enqueue(700);
//queueLinkedList.List();


//DSA.StackQueue.QueueArray queueArray = new DSA.StackQueue.QueueArray(5);
//queueArray.Enqueue(100);
//queueArray.Enqueue(200);
//queueArray.Enqueue(300);
//Console.WriteLine(queueArray.Dequeue());
//queueArray.Enqueue(400);
//Console.WriteLine(queueArray.Dequeue());
//queueArray.Enqueue(500);
//queueArray.Enqueue(600);
//Console.WriteLine(queueArray.Dequeue());
//queueArray.Enqueue(700);
//queueArray.Enqueue(800);
//queueArray.Enqueue(900);
//Console.WriteLine(queueArray.Dequeue());
//Console.WriteLine("---");
//queueArray.List();
//Console.WriteLine(queueArray.Dequeue());
//queueArray.List();

//DSA.StackQueue.StackLinkedList stackLinkedList = new DSA.StackQueue.StackLinkedList(100);
//stackLinkedList.Push(200);
//stackLinkedList.Push(300);
//stackLinkedList.Push(400);
//Console.WriteLine(stackLinkedList.Pop());
//stackLinkedList.Push(500);
//Console.WriteLine(stackLinkedList.Peek());
//stackLinkedList.Push(600);
//stackLinkedList.List();

//DSA.StackQueue.StackArray stackArray = new DSA.StackQueue.StackArray(10);
//stackArray.Print();
//stackArray.Push(100);
//stackArray.Push(200);
//stackArray.Push(300);
//stackArray.Push(400);
//Console.WriteLine(stackArray.Pop());
//stackArray.Push(500);
//stackArray.Push(600);
//Console.WriteLine(stackArray.Peek());
//stackArray.Push(700);
//stackArray.Print();

//DSA.LinkedList.CircularDoublyLinkedList circularDoublyLinkedList = new DSA.LinkedList.CircularDoublyLinkedList(100);
//circularDoublyLinkedList.AppendNode(200);
//circularDoublyLinkedList.AppendNode(400);
//circularDoublyLinkedList.AppendNode(500);
//circularDoublyLinkedList.InsertNode(2, 300);
//circularDoublyLinkedList.AppendNode(550);
//circularDoublyLinkedList.PrependNode(50);
//circularDoublyLinkedList.ListNode();
//circularDoublyLinkedList.RemoveFirst();
//circularDoublyLinkedList.RemoveLast();
//circularDoublyLinkedList.ListNode();
//circularDoublyLinkedList.SetNode(2, 350);
//circularDoublyLinkedList.ListNode();
//circularDoublyLinkedList.RemoveNode(2);
//circularDoublyLinkedList.ListNode();
//circularDoublyLinkedList.Reverse();
//circularDoublyLinkedList.ListNode();

//Console.WriteLine(JsonSerializer.Serialize(circularDoublyLinkedList.Head, new JsonSerializerOptions { WriteIndented = true,ReferenceHandler = ReferenceHandler.IgnoreCycles  }));
//Console.WriteLine(JsonSerializer.Serialize(circularDoublyLinkedList.Tail, new JsonSerializerOptions { WriteIndented = true, ReferenceHandler = ReferenceHandler.IgnoreCycles }));

//DSA.LinkedList.DoublyLinkedList doublyLinkedList = new DSA.LinkedList.DoublyLinkedList(100);
//doublyLinkedList.AppendNode(200);
//doublyLinkedList.AppendNode(400);
//doublyLinkedList.AppendNode(500);
//doublyLinkedList.InsertNode(2, 300);
//doublyLinkedList.AppendNode(550);
//doublyLinkedList.PrependNode(50);
//doublyLinkedList.ListNode();
//doublyLinkedList.RemoveFirst();
//doublyLinkedList.RemoveLast();
//doublyLinkedList.ListNode();
//doublyLinkedList.SetNode(2, 350);
//doublyLinkedList.ListNode();
//doublyLinkedList.RemoveNode(2);
//doublyLinkedList.ListNode();
//doublyLinkedList.Reverse();
//doublyLinkedList.ListNode();


//DSA.LinkedList.CircularSingleLinkedList circularSingleLinkedList = new DSA.LinkedList.CircularSingleLinkedList(100);
//circularSingleLinkedList.AppendNode(200);
//circularSingleLinkedList.AppendNode(400);
//circularSingleLinkedList.AppendNode(500);
//circularSingleLinkedList.InsertNode(2, 300);
//circularSingleLinkedList.AppendNode(550);
//circularSingleLinkedList.PrependNode(50);
//circularSingleLinkedList.ListNode();
//circularSingleLinkedList.RemoveFirst();
//circularSingleLinkedList.RemoveLast();
//circularSingleLinkedList.ListNode();
//circularSingleLinkedList.SetNode(2, 350);
//circularSingleLinkedList.ListNode();
//circularSingleLinkedList.RemoveNode(2);
//circularSingleLinkedList.ListNode();
//circularSingleLinkedList.Reverse();
//circularSingleLinkedList.ListNode();


//DSA.LinkedList.SingleLinkedList singleLinkedList = new DSA.LinkedList.SingleLinkedList(100);
//singleLinkedList.AppendNode(200);
//singleLinkedList.AppendNode(400);
//singleLinkedList.AppendNode(500);
//singleLinkedList.InsertNode(2,300);
//singleLinkedList.AppendNode(550);
//singleLinkedList.PrependNode(50);
//singleLinkedList.ListNode();
//singleLinkedList.RemoveFirst();
//singleLinkedList.RemoveLast();
//singleLinkedList.ListNode();
//singleLinkedList.SetNode(2, 350);
//singleLinkedList.ListNode();
//singleLinkedList.RemoveNode(2);
//singleLinkedList.ListNode();
//singleLinkedList.Reverse();
//singleLinkedList.ListNode();


//DSA.Array.Array.RotateMatrix(new int[4,4] { { 1, 2, 3, 4 }, { 5, 6, 7,8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16} });

//Console.WriteLine(DSA.Array.Array.Permutation(new int[] { 1,6, 2, 3, 9, 2}, new int[] { 2, 9, 2, 3, 6, 1 }));

//DSA.Array.Array.Duplicate(new int[] { 8,3,6,5,0,9,2,7 });

//DSA.Array.Array.MaxProduct(new int[] { 7, 5, 3, 4, 5, 1, 8, 0, 9 });

//DSA.Array.Array.TwoSum(new int[] { 7, 1, 2, 3, 4, 5, 1, 6, 8, 9}, 7);

//DSA.Array.Array.FindMissingNo(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 14, 15 });

//DSA.Array.TwoDimensionArray twoDimensionArray = new DSA.Array.TwoDimensionArray(4,7);
//twoDimensionArray.Display();

//DSA.Array.SingleDimensionArray singleDimensionArray = new DSA.Array.SingleDimensionArray(10);
//singleDimensionArray.Insert(0, 34);
//singleDimensionArray.Insert(1, 94);
//singleDimensionArray.Insert(2, 27);
//singleDimensionArray.Insert(3, 29);
//singleDimensionArray.Insert(4, 60);
//singleDimensionArray.Insert(9, 12);
//singleDimensionArray.Delete(3);
//singleDimensionArray.Display();
//singleDimensionArray.Find(29);

//DSA.Array.Array.ArrayReverse(new int[] { 1, 3, 4, 5, 9, 0 });

//Console.WriteLine(DSA.Recursion.Recursion.Power(5, 3));

//Console.WriteLine(DSA.Recursion.Recursion.SumOfDigit(739));

//Console.WriteLine(DSA.Recursion.Recursion.Fibonacci(8, 0));

//Console.WriteLine(DSA.Recursion.Recursion.Factorial(5));


