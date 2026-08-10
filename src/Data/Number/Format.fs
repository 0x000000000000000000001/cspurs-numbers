let toPrecisionNative = 
    fun (dVal: obj) -> fun (numVal: obj) ->
        let d = dVal :?> int
        let num = numVal :?> float
        box (num.ToString("G" + d.ToString(), System.Globalization.CultureInfo.InvariantCulture))

let toFixedNative = 
    fun (dVal: obj) -> fun (numVal: obj) ->
        let d = dVal :?> int
        let num = numVal :?> float
        box (num.ToString("F" + d.ToString(), System.Globalization.CultureInfo.InvariantCulture))

let toExponentialNative = 
    fun (dVal: obj) -> fun (numVal: obj) ->
        let d = dVal :?> int
        let num = numVal :?> float
        box (num.ToString("E" + d.ToString(), System.Globalization.CultureInfo.InvariantCulture))

let toString = 
    fun (numVal: obj) ->
        let num = numVal :?> float
        box (num.ToString(System.Globalization.CultureInfo.InvariantCulture))
