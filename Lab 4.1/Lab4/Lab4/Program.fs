// Learn more about F# at http://fsharp.net

module TESTLIST
   open LIST

   let test = Cons(Cons(Cons(Cons(Create, 3), 2), 3),3)
   printfn "test = %O" test
   printfn "test has %i elements" (Length test)
   printfn "Head(test) = %O" (Head test)
   printfn "Tail(test) = %O" (Tail test)
   printfn "Cons(test, GetByIndex(test, 2)) = %O" (Cons(test, GetByIndex(test, 2)))
   printfn "GetByIndex(test, 3) = %O" (GetByIndex(test, 3))
   
   
   // TO DO: Add some code to test Count and CircShift here
   printfn "Shifted (test, 1)  = %O" (CircShift(test,1))
   printfn "Shifted (test, 2)  = %O" (CircShift(test,2))
   printfn "Shifted (test, 3)  = %O" (CircShift(test,3))
   printfn "Shifted (test, 4)  = %O" (CircShift(test,4))
   
   printfn "(Count (test, 1)) = %O" (Count( test, 1))
   printfn "(Count (test, 2)) = %O" (Count( test, 2))
   printfn "(Count (test, 3)) = %O" (Count( test, 3))
   printfn "(Count (test, 5)) = %O" (Count( test, 5))   
   
   printf "Press any key to exit..."
   ignore (System.Console.ReadKey(true))