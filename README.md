# GraphVizWrapper
Wrapper for graphviz visualization engine (http://www.graphviz.org/)

CODE:

            Node nod1 = new Node("node_one");

            nod1.AddStyle("color", "red");

            Node nod2 = new Node("node_two");

            nod2.AddStyle("color", "blue");
            nod2.AddStyle("shape", "circle");

            Edge ed1 = new Edge(nod1, nod2);
            Edge ed2 = new Edge();

            Graph gr = new Graph();
            gr.AddNode(nod1);

            ed1.AddStyle("style", "solid");
            gr.AddEdge(ed1);

            Console.WriteLine(gr.ToString());



OUTPUT:

                        digraph G {
                            rankdir=LR;
                            node[shape=record];
                            
                            /*Nodes*/
                            node_one[color="red" ]
                            node_two[color="blue" shape="circle" ]
                            
                            /*Edges*/
                            node_one->node_two [style="solid" ];
                        
                        }
                        

