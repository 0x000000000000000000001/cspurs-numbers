let nan = box System.Double.NaN
let isNaN = fun (x: obj) -> box (System.Double.IsNaN(x :?> float))
let infinity = box System.Double.PositiveInfinity
let isFinite = fun (x: obj) -> box (not (System.Double.IsInfinity(x :?> float)) && not (System.Double.IsNaN(x :?> float)))

let fromStringImpl = 
    fun (strVal: obj) -> fun (isFiniteFn: obj) -> fun (just: obj) -> fun (nothing: obj) ->
        let str = strVal :?> string
        match System.Double.TryParse(str, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture) with
        | true, num -> 
            let isFin = isFiniteFn :?> (obj -> obj)
            let just' = just :?> (obj -> obj)
            if isFin (box num) :?> bool then
                just' (box num)
            else
                nothing
        | _ -> nothing

let abs = fun (x: obj) -> box (System.Math.Abs(x :?> float))
let acos = fun (x: obj) -> box (System.Math.Acos(x :?> float))
let asin = fun (x: obj) -> box (System.Math.Asin(x :?> float))
let atan = fun (x: obj) -> box (System.Math.Atan(x :?> float))
let atan2 = fun (y: obj) -> fun (x: obj) -> box (System.Math.Atan2(y :?> float, x :?> float))
let ceil = fun (x: obj) -> box (System.Math.Ceiling(x :?> float))
let cos = fun (x: obj) -> box (System.Math.Cos(x :?> float))
let exp = fun (x: obj) -> box (System.Math.Exp(x :?> float))
let floor = fun (x: obj) -> box (System.Math.Floor(x :?> float))
let log = fun (x: obj) -> box (System.Math.Log(x :?> float))
let max = fun (n1: obj) -> fun (n2: obj) -> box (System.Math.Max(n1 :?> float, n2 :?> float))
let min = fun (n1: obj) -> fun (n2: obj) -> box (System.Math.Min(n1 :?> float, n2 :?> float))
let pow = fun (n: obj) -> fun (p: obj) -> box (System.Math.Pow(n :?> float, p :?> float))
let remainder = fun (n: obj) -> fun (m: obj) -> box ((n :?> float) % (m :?> float))
let round = fun (x: obj) -> box (System.Math.Round(x :?> float))
let sign = fun (x: obj) -> box (float (System.Math.Sign(x :?> float)))
let sin = fun (x: obj) -> box (System.Math.Sin(x :?> float))
let sqrt = fun (x: obj) -> box (System.Math.Sqrt(x :?> float))
let tan = fun (x: obj) -> box (System.Math.Tan(x :?> float))
let trunc = fun (x: obj) -> box (System.Math.Truncate(x :?> float))
