module LIST

open System.Linq.Expressions

   type List<'Element when 'Element: equality> = 
   | Create 
   | Cons of 'Element List * 'Element
      override l.ToString() = "[" + l._ToString() + "]"
      member private l._ToString() =
         match l with 
         | Create -> "" 
         | Cons (Create, e) -> e.ToString()
         | Cons (l1, e) -> l1._ToString() + ", " + e.ToString()

   let rec Length l =
      match l with Create -> 0 | Cons (l', v) -> 1 + Length l'

   let rec Head l =
      match l with 
      | Create -> failwith "Head of empty list" 
      | Cons (Create, e) -> e 
      | Cons (l', e) -> Head l'

   let rec Tail l =
      match l with 
      | Create -> Create 
      | Cons (Create, e) -> Create
      | Cons (l', e) -> if l' = Create then Create else Cons (Tail l', e)

   let rec _GetByIndex (l, n) =
      match n with
      |  1 -> Head l
      |  _ -> _GetByIndex (Tail l, n - 1)

   let GetByIndex (l, n) =      // What happens if l = Create?
      if n < 1 || n > Length l then 
         failwith "Index out of bounds"
      else
         _GetByIndex (l, n)
  
  
  // TO DO: Add implementation of Count and CircShift here
   
   let rec CircShift(l, n) =
        match n with
        | 0 -> l
        | _ -> CircShift(Cons(Tail l, Head l), n-1)
   
   let _Count (l, n) =
    let mutable cont = 1
    let mutable num = 0
    while cont <= Length l do
     if GetByIndex(CircShift(l, 1), cont) = n then
      num <- num + 1
     cont <- cont + 1
    num

   let Count (l, n) =
      if Length l = 0 then
       0
      else
        _Count(l, n)