(+)
let plus = uncurry (+)
let uncurry x y = (x,y)
let plus = uncurry (+)
let uncurry = (x,y)
let uncurry = (int x,int y)
let uncurry (x,y) = x y
let plus = uncurry (+)
let uncurry x = (y, z)
let testA   = float 2

let testA   = float 2

let testA   = float 2

let testB x = float 2

let testC x = float 2 + x

let testN x = x 1          // hint: what kind of thing is x?

let uncurry (x,y) = x y

let uncurry (x,y) = int x y
let uncurry (x,y) = ()
let uncurry (x,y) = (int,int)
let uncurry (x,y) = int int
let uncurry (int x,int y) = ()
let uncurry (x,y) = ()
uncurry 3

let x = List.rev [] in 3::x
x 5
x
x [5]
let revlists = (fun xs -> List.map List.rev xs)
revlists [[1;2];[3;4]]

 let rec insert n = function
  | Lf            -> Br(n, Lf, Lf)
  | Br(m, t1, t2) ->
      if n < m then Br(m, insert n t1, t2)
      
type 'a tree = 
    |Lf
    |Br of 'a * 'a tree * 'a tree



let rec insert n = function
  | Lf -> Br(n, Lf, Lf)
  | Br(m, t1, t2) ->
    if n < m then Br(m, insert n t1, t2)

 let rec insert n = function
  | Lf -> Br(n, Lf, Lf)
  | Br(m, t1, t2) -> if n < m then Br(m, insert n t1, t2)

 let rec insert n = function
  | Lf -> Br(n, Lf, Lf)
  | Br(m, t1, t2) -> if n < m then Br(m, insert n t1, t2)
                     else Br(m, t1, insert n t2)
let rec buildtree = function
  | [] -> Lf
  | x::xs -> insert x (buildtree xs)
buildtree [1;2;3;4]
let uncurry f (x,y) = f x y
let plus = uncurry (+)
plus (2,3)
(+) 3 4
(+)