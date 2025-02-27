open System

printf "Введите размерность списка: "
let n = int(Console.ReadLine())
printfn "Введите числа через Enter: "

let list = [
    for i in 1..n do
        yield int(Console.ReadLine())
]

let list1 = list |> List.map (fun x -> -x)

printfn "Начальный список: %A" list
printfn "Обратный список: %A" list1



