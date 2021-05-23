<a name='assembly'></a>
# WPFNumericUpDn

## Contents

- [DoubleNumber](#T-WPFNumericUpDn-DoubleNumber 'WPFNumericUpDn.DoubleNumber')
  - [#ctor(value,min,max,inc,decimals)](#M-WPFNumericUpDn-DoubleNumber-#ctor-System-Double,System-Double,System-Double,System-Double,System-Int32- 'WPFNumericUpDn.DoubleNumber.#ctor(System.Double,System.Double,System.Double,System.Double,System.Int32)')
  - [FormatString](#P-WPFNumericUpDn-DoubleNumber-FormatString 'WPFNumericUpDn.DoubleNumber.FormatString')
  - [_regex](#P-WPFNumericUpDn-DoubleNumber-_regex 'WPFNumericUpDn.DoubleNumber._regex')
  - [ConvertToValue(result)](#M-WPFNumericUpDn-DoubleNumber-ConvertToValue-System-Double@- 'WPFNumericUpDn.DoubleNumber.ConvertToValue(System.Double@)')
  - [decrement()](#M-WPFNumericUpDn-DoubleNumber-decrement 'WPFNumericUpDn.DoubleNumber.decrement')
  - [increment()](#M-WPFNumericUpDn-DoubleNumber-increment 'WPFNumericUpDn.DoubleNumber.increment')
- [DoubleNumericControl](#T-WPFNumericUpDn-DoubleNumericControl 'WPFNumericUpDn.DoubleNumericControl')
  - [#ctor()](#M-WPFNumericUpDn-DoubleNumericControl-#ctor 'WPFNumericUpDn.DoubleNumericControl.#ctor')
- [FloatNumber](#T-WPFNumericUpDn-FloatNumber 'WPFNumericUpDn.FloatNumber')
  - [#ctor(value,min,max,inc,decimals)](#M-WPFNumericUpDn-FloatNumber-#ctor-System-Single,System-Single,System-Single,System-Single,System-Int32- 'WPFNumericUpDn.FloatNumber.#ctor(System.Single,System.Single,System.Single,System.Single,System.Int32)')
  - [FormatString](#P-WPFNumericUpDn-FloatNumber-FormatString 'WPFNumericUpDn.FloatNumber.FormatString')
  - [_regex](#P-WPFNumericUpDn-FloatNumber-_regex 'WPFNumericUpDn.FloatNumber._regex')
  - [ConvertToValue(result)](#M-WPFNumericUpDn-FloatNumber-ConvertToValue-System-Single@- 'WPFNumericUpDn.FloatNumber.ConvertToValue(System.Single@)')
  - [decrement()](#M-WPFNumericUpDn-FloatNumber-decrement 'WPFNumericUpDn.FloatNumber.decrement')
  - [increment()](#M-WPFNumericUpDn-FloatNumber-increment 'WPFNumericUpDn.FloatNumber.increment')
- [FloatNumericControl](#T-WPFNumericUpDn-FloatNumericControl 'WPFNumericUpDn.FloatNumericControl')
  - [#ctor()](#M-WPFNumericUpDn-FloatNumericControl-#ctor 'WPFNumericUpDn.FloatNumericControl.#ctor')
- [GenericNumber\`1](#T-WPFNumericUpDn-GenericNumber`1 'WPFNumericUpDn.GenericNumber`1')
  - [#ctor(value,min,max,inc,decimals)](#M-WPFNumericUpDn-GenericNumber`1-#ctor-`0,`0,`0,`0,System-Int32- 'WPFNumericUpDn.GenericNumber`1.#ctor(`0,`0,`0,`0,System.Int32)')
  - [_decimals](#F-WPFNumericUpDn-GenericNumber`1-_decimals 'WPFNumericUpDn.GenericNumber`1._decimals')
  - [_increment](#F-WPFNumericUpDn-GenericNumber`1-_increment 'WPFNumericUpDn.GenericNumber`1._increment')
  - [_max](#F-WPFNumericUpDn-GenericNumber`1-_max 'WPFNumericUpDn.GenericNumber`1._max')
  - [_min](#F-WPFNumericUpDn-GenericNumber`1-_min 'WPFNumericUpDn.GenericNumber`1._min')
  - [_stringValue](#F-WPFNumericUpDn-GenericNumber`1-_stringValue 'WPFNumericUpDn.GenericNumber`1._stringValue')
  - [_value](#F-WPFNumericUpDn-GenericNumber`1-_value 'WPFNumericUpDn.GenericNumber`1._value')
  - [signedDecimal](#F-WPFNumericUpDn-GenericNumber`1-signedDecimal 'WPFNumericUpDn.GenericNumber`1.signedDecimal')
  - [signedInteger](#F-WPFNumericUpDn-GenericNumber`1-signedInteger 'WPFNumericUpDn.GenericNumber`1.signedInteger')
  - [unSignedDecimal](#F-WPFNumericUpDn-GenericNumber`1-unSignedDecimal 'WPFNumericUpDn.GenericNumber`1.unSignedDecimal')
  - [unSignedInteger](#F-WPFNumericUpDn-GenericNumber`1-unSignedInteger 'WPFNumericUpDn.GenericNumber`1.unSignedInteger')
  - [DecrementCommand](#P-WPFNumericUpDn-GenericNumber`1-DecrementCommand 'WPFNumericUpDn.GenericNumber`1.DecrementCommand')
  - [FormatString](#P-WPFNumericUpDn-GenericNumber`1-FormatString 'WPFNumericUpDn.GenericNumber`1.FormatString')
  - [IncrementCommand](#P-WPFNumericUpDn-GenericNumber`1-IncrementCommand 'WPFNumericUpDn.GenericNumber`1.IncrementCommand')
  - [StringValue](#P-WPFNumericUpDn-GenericNumber`1-StringValue 'WPFNumericUpDn.GenericNumber`1.StringValue')
  - [Value](#P-WPFNumericUpDn-GenericNumber`1-Value 'WPFNumericUpDn.GenericNumber`1.Value')
  - [_regex](#P-WPFNumericUpDn-GenericNumber`1-_regex 'WPFNumericUpDn.GenericNumber`1._regex')
  - [ConvertToString()](#M-WPFNumericUpDn-GenericNumber`1-ConvertToString 'WPFNumericUpDn.GenericNumber`1.ConvertToString')
  - [ConvertToValue(val)](#M-WPFNumericUpDn-GenericNumber`1-ConvertToValue-`0@- 'WPFNumericUpDn.GenericNumber`1.ConvertToValue(`0@)')
  - [Decrement()](#M-WPFNumericUpDn-GenericNumber`1-Decrement 'WPFNumericUpDn.GenericNumber`1.Decrement')
  - [Increment()](#M-WPFNumericUpDn-GenericNumber`1-Increment 'WPFNumericUpDn.GenericNumber`1.Increment')
  - [decrement()](#M-WPFNumericUpDn-GenericNumber`1-decrement 'WPFNumericUpDn.GenericNumber`1.decrement')
  - [increment()](#M-WPFNumericUpDn-GenericNumber`1-increment 'WPFNumericUpDn.GenericNumber`1.increment')
- [GenericNumericControl\`1](#T-WPFNumericUpDn-GenericNumericControl`1 'WPFNumericUpDn.GenericNumericControl`1')
  - [#ctor()](#M-WPFNumericUpDn-GenericNumericControl`1-#ctor 'WPFNumericUpDn.GenericNumericControl`1.#ctor')
  - [#ctor(data)](#M-WPFNumericUpDn-GenericNumericControl`1-#ctor-WPFNumericUpDn-GenericNumber{`0}- 'WPFNumericUpDn.GenericNumericControl`1.#ctor(WPFNumericUpDn.GenericNumber{`0})')
  - [DATAProperty](#F-WPFNumericUpDn-GenericNumericControl`1-DATAProperty 'WPFNumericUpDn.GenericNumericControl`1.DATAProperty')
  - [DATA](#P-WPFNumericUpDn-GenericNumericControl`1-DATA 'WPFNumericUpDn.GenericNumericControl`1.DATA')
  - [_regexPattern](#P-WPFNumericUpDn-GenericNumericControl`1-_regexPattern 'WPFNumericUpDn.GenericNumericControl`1._regexPattern')
  - [dataBinding()](#M-WPFNumericUpDn-GenericNumericControl`1-dataBinding 'WPFNumericUpDn.GenericNumericControl`1.dataBinding')
- [InputBindingsManager](#T-WPFNumericUpDn-InputBindingsManager 'WPFNumericUpDn.InputBindingsManager')
  - [UpdatePropertySourceWhenEnterPressedProperty](#F-WPFNumericUpDn-InputBindingsManager-UpdatePropertySourceWhenEnterPressedProperty 'WPFNumericUpDn.InputBindingsManager.UpdatePropertySourceWhenEnterPressedProperty')
  - [GetUpdatePropertySourceWhenEnterPressed(dp)](#M-WPFNumericUpDn-InputBindingsManager-GetUpdatePropertySourceWhenEnterPressed-System-Windows-DependencyObject- 'WPFNumericUpDn.InputBindingsManager.GetUpdatePropertySourceWhenEnterPressed(System.Windows.DependencyObject)')
  - [SetUpdatePropertySourceWhenEnterPressed(dp,value)](#M-WPFNumericUpDn-InputBindingsManager-SetUpdatePropertySourceWhenEnterPressed-System-Windows-DependencyObject,System-Windows-DependencyProperty- 'WPFNumericUpDn.InputBindingsManager.SetUpdatePropertySourceWhenEnterPressed(System.Windows.DependencyObject,System.Windows.DependencyProperty)')
- [IntegerNumber](#T-WPFNumericUpDn-IntegerNumber 'WPFNumericUpDn.IntegerNumber')
  - [#ctor(value,min,max,inc)](#M-WPFNumericUpDn-IntegerNumber-#ctor-System-Int32,System-Int32,System-Int32,System-Int32- 'WPFNumericUpDn.IntegerNumber.#ctor(System.Int32,System.Int32,System.Int32,System.Int32)')
  - [FormatString](#P-WPFNumericUpDn-IntegerNumber-FormatString 'WPFNumericUpDn.IntegerNumber.FormatString')
  - [_regex](#P-WPFNumericUpDn-IntegerNumber-_regex 'WPFNumericUpDn.IntegerNumber._regex')
  - [ConvertToValue(result)](#M-WPFNumericUpDn-IntegerNumber-ConvertToValue-System-Int32@- 'WPFNumericUpDn.IntegerNumber.ConvertToValue(System.Int32@)')
  - [decrement()](#M-WPFNumericUpDn-IntegerNumber-decrement 'WPFNumericUpDn.IntegerNumber.decrement')
  - [increment()](#M-WPFNumericUpDn-IntegerNumber-increment 'WPFNumericUpDn.IntegerNumber.increment')
- [IntegerNumericControl](#T-WPFNumericUpDn-IntegerNumericControl 'WPFNumericUpDn.IntegerNumericControl')
  - [#ctor()](#M-WPFNumericUpDn-IntegerNumericControl-#ctor 'WPFNumericUpDn.IntegerNumericControl.#ctor')
- [NumbericControl](#T-WPFNumericUpDn-NumbericControl 'WPFNumericUpDn.NumbericControl')
  - [#ctor()](#M-WPFNumericUpDn-NumbericControl-#ctor 'WPFNumericUpDn.NumbericControl.#ctor')
  - [InitializeComponent()](#M-WPFNumericUpDn-NumbericControl-InitializeComponent 'WPFNumericUpDn.NumbericControl.InitializeComponent')
  - [Timer_Elapsed(sender,e)](#M-WPFNumericUpDn-NumbericControl-Timer_Elapsed-System-Object,System-Timers-ElapsedEventArgs- 'WPFNumericUpDn.NumbericControl.Timer_Elapsed(System.Object,System.Timers.ElapsedEventArgs)')
  - [incBTN_MouseLeftButtonDown(sender,e)](#M-WPFNumericUpDn-NumbericControl-incBTN_MouseLeftButtonDown-System-Object,System-Windows-Input-MouseButtonEventArgs- 'WPFNumericUpDn.NumbericControl.incBTN_MouseLeftButtonDown(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [incBTN_MouseLeftButtonUp(sender,e)](#M-WPFNumericUpDn-NumbericControl-incBTN_MouseLeftButtonUp-System-Object,System-Windows-Input-MouseButtonEventArgs- 'WPFNumericUpDn.NumbericControl.incBTN_MouseLeftButtonUp(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [textBox_PreviewTextInput(sender,e)](#M-WPFNumericUpDn-NumbericControl-textBox_PreviewTextInput-System-Object,System-Windows-Input-TextCompositionEventArgs- 'WPFNumericUpDn.NumbericControl.textBox_PreviewTextInput(System.Object,System.Windows.Input.TextCompositionEventArgs)')

<a name='T-WPFNumericUpDn-DoubleNumber'></a>
## DoubleNumber `type`

##### Namespace

WPFNumericUpDn

##### Summary

this class represent a formatted double number with constrains

<a name='M-WPFNumericUpDn-DoubleNumber-#ctor-System-Double,System-Double,System-Double,System-Double,System-Int32-'></a>
### #ctor(value,min,max,inc,decimals) `constructor`

##### Summary

construct a constrained double number

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') |  |
| min | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') |  |
| max | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') |  |
| inc | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') |  |
| decimals | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='P-WPFNumericUpDn-DoubleNumber-FormatString'></a>
### FormatString `property`

##### Summary



<a name='P-WPFNumericUpDn-DoubleNumber-_regex'></a>
### _regex `property`

##### Summary



<a name='M-WPFNumericUpDn-DoubleNumber-ConvertToValue-System-Double@-'></a>
### ConvertToValue(result) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [System.Double@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double@ 'System.Double@') |  |

<a name='M-WPFNumericUpDn-DoubleNumber-decrement'></a>
### decrement() `method`

##### Summary



##### Returns



##### Parameters

This method has no parameters.

<a name='M-WPFNumericUpDn-DoubleNumber-increment'></a>
### increment() `method`

##### Summary



##### Returns



##### Parameters

This method has no parameters.

<a name='T-WPFNumericUpDn-DoubleNumericControl'></a>
## DoubleNumericControl `type`

##### Namespace

WPFNumericUpDn

##### Summary

Class represent a numeric up down control for double vlaue

<a name='M-WPFNumericUpDn-DoubleNumericControl-#ctor'></a>
### #ctor() `constructor`

##### Summary

default constructor for double numbder with 4 decimals (default value 0)

##### Parameters

This constructor has no parameters.

<a name='T-WPFNumericUpDn-FloatNumber'></a>
## FloatNumber `type`

##### Namespace

WPFNumericUpDn

##### Summary

class represnet a constrained float number

<a name='M-WPFNumericUpDn-FloatNumber-#ctor-System-Single,System-Single,System-Single,System-Single,System-Int32-'></a>
### #ctor(value,min,max,inc,decimals) `constructor`

##### Summary

construc a constrain Float number

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') |  |
| min | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') |  |
| max | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') |  |
| inc | [System.Single](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single 'System.Single') |  |
| decimals | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='P-WPFNumericUpDn-FloatNumber-FormatString'></a>
### FormatString `property`

##### Summary



<a name='P-WPFNumericUpDn-FloatNumber-_regex'></a>
### _regex `property`

##### Summary



<a name='M-WPFNumericUpDn-FloatNumber-ConvertToValue-System-Single@-'></a>
### ConvertToValue(result) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [System.Single@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Single@ 'System.Single@') |  |

<a name='M-WPFNumericUpDn-FloatNumber-decrement'></a>
### decrement() `method`

##### Summary



##### Returns



##### Parameters

This method has no parameters.

<a name='M-WPFNumericUpDn-FloatNumber-increment'></a>
### increment() `method`

##### Summary



##### Returns



##### Parameters

This method has no parameters.

<a name='T-WPFNumericUpDn-FloatNumericControl'></a>
## FloatNumericControl `type`

##### Namespace

WPFNumericUpDn

##### Summary

Class represent a numeric up down control for float vlaue

<a name='M-WPFNumericUpDn-FloatNumericControl-#ctor'></a>
### #ctor() `constructor`

##### Summary

construct a non-constrain float numbder with 2 decimals (default value 0)

##### Parameters

This constructor has no parameters.

<a name='T-WPFNumericUpDn-GenericNumber`1'></a>
## GenericNumber\`1 `type`

##### Namespace

WPFNumericUpDn

##### Summary

class provide basic functionality for different number classes

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-WPFNumericUpDn-GenericNumber`1-#ctor-`0,`0,`0,`0,System-Int32-'></a>
### #ctor(value,min,max,inc,decimals) `constructor`

##### Summary

construct a GenericNumber class based on the Type (T)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`0](#T-`0 '`0') | current value |
| min | [\`0](#T-`0 '`0') | minimum value |
| max | [\`0](#T-`0 '`0') | maximum value |
| inc | [\`0](#T-`0 '`0') | increment value used to increment or decrement the current value |
| decimals | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | number of deciams shown on the text box |

<a name='F-WPFNumericUpDn-GenericNumber`1-_decimals'></a>
### _decimals `constants`

##### Summary

number of decimals shown in the textbox

<a name='F-WPFNumericUpDn-GenericNumber`1-_increment'></a>
### _increment `constants`

##### Summary

value used to increment or decrement the current value

<a name='F-WPFNumericUpDn-GenericNumber`1-_max'></a>
### _max `constants`

##### Summary

maximum value

<a name='F-WPFNumericUpDn-GenericNumber`1-_min'></a>
### _min `constants`

##### Summary

minimum value

<a name='F-WPFNumericUpDn-GenericNumber`1-_stringValue'></a>
### _stringValue `constants`

##### Summary

the string value corressponding to the current value

<a name='F-WPFNumericUpDn-GenericNumber`1-_value'></a>
### _value `constants`

##### Summary

the current value

<a name='F-WPFNumericUpDn-GenericNumber`1-signedDecimal'></a>
### signedDecimal `constants`

##### Summary

filters the signed decimals

<a name='F-WPFNumericUpDn-GenericNumber`1-signedInteger'></a>
### signedInteger `constants`

##### Summary

filters the signed integers

<a name='F-WPFNumericUpDn-GenericNumber`1-unSignedDecimal'></a>
### unSignedDecimal `constants`

##### Summary

filters the unsigned decimals

<a name='F-WPFNumericUpDn-GenericNumber`1-unSignedInteger'></a>
### unSignedInteger `constants`

##### Summary

filters the unsigned integers

<a name='P-WPFNumericUpDn-GenericNumber`1-DecrementCommand'></a>
### DecrementCommand `property`

##### Summary

create an instance of the `DecrementCommand` for the increment button in UI

<a name='P-WPFNumericUpDn-GenericNumber`1-FormatString'></a>
### FormatString `property`

##### Summary

override to provide the format string used to format the string in the text box

<a name='P-WPFNumericUpDn-GenericNumber`1-IncrementCommand'></a>
### IncrementCommand `property`

##### Summary

create an instance of the `IncrementCommand` for the increment button in UI

<a name='P-WPFNumericUpDn-GenericNumber`1-StringValue'></a>
### StringValue `property`

##### Summary

The string value shown in the text box .
this property fires the `NotifyPropertyChanged`

<a name='P-WPFNumericUpDn-GenericNumber`1-Value'></a>
### Value `property`

##### Summary

get and sets the current value

<a name='P-WPFNumericUpDn-GenericNumber`1-_regex'></a>
### _regex `property`

##### Summary

provides the regex pattern for filtering numerical value based on the type (T) and lower bound (_min)

<a name='M-WPFNumericUpDn-GenericNumber`1-ConvertToString'></a>
### ConvertToString() `method`

##### Summary

convert the current value to the string

##### Returns



##### Parameters

This method has no parameters.

<a name='M-WPFNumericUpDn-GenericNumber`1-ConvertToValue-`0@-'></a>
### ConvertToValue(val) `method`

##### Summary

override this method to parse the current string to type (T)

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| val | [\`0@](#T-`0@ '`0@') |  |

<a name='M-WPFNumericUpDn-GenericNumber`1-Decrement'></a>
### Decrement() `method`

##### Summary

decrement the current value by subtracting the `_increment` value from the current value

##### Parameters

This method has no parameters.

<a name='M-WPFNumericUpDn-GenericNumber`1-Increment'></a>
### Increment() `method`

##### Summary

increment the current value by adding the `_increment` value to the current value

##### Parameters

This method has no parameters.

<a name='M-WPFNumericUpDn-GenericNumber`1-decrement'></a>
### decrement() `method`

##### Summary

returns `_value - _increment`

##### Returns



##### Parameters

This method has no parameters.

<a name='M-WPFNumericUpDn-GenericNumber`1-increment'></a>
### increment() `method`

##### Summary

returns `_value + _increment`

##### Returns



##### Parameters

This method has no parameters.

<a name='T-WPFNumericUpDn-GenericNumericControl`1'></a>
## GenericNumericControl\`1 `type`

##### Namespace

WPFNumericUpDn

##### Summary

class represent generic number. any other type must be sub-class of the this class

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-WPFNumericUpDn-GenericNumericControl`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

empty constructor is require for XML code

##### Parameters

This constructor has no parameters.

<a name='M-WPFNumericUpDn-GenericNumericControl`1-#ctor-WPFNumericUpDn-GenericNumber{`0}-'></a>
### #ctor(data) `constructor`

##### Summary

constructor can be used from code.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| data | [WPFNumericUpDn.GenericNumber{\`0}](#T-WPFNumericUpDn-GenericNumber{`0} 'WPFNumericUpDn.GenericNumber{`0}') | data to be binded with text box |

<a name='F-WPFNumericUpDn-GenericNumericControl`1-DATAProperty'></a>
### DATAProperty `constants`

##### Summary

dependency property for binding

<a name='P-WPFNumericUpDn-GenericNumericControl`1-DATA'></a>
### DATA `property`

##### Summary

data source for the textbox

<a name='P-WPFNumericUpDn-GenericNumericControl`1-_regexPattern'></a>
### _regexPattern `property`

##### Summary

return the regex pattern provided in data source

<a name='M-WPFNumericUpDn-GenericNumericControl`1-dataBinding'></a>
### dataBinding() `method`

##### Summary

binds the model to UI.

##### Parameters

This method has no parameters.

<a name='T-WPFNumericUpDn-InputBindingsManager'></a>
## InputBindingsManager `type`

##### Namespace

WPFNumericUpDn

##### Summary

privides custom behaviour for the text box and  used to update the source when user press the enter

<a name='F-WPFNumericUpDn-InputBindingsManager-UpdatePropertySourceWhenEnterPressedProperty'></a>
### UpdatePropertySourceWhenEnterPressedProperty `constants`

##### Summary



<a name='M-WPFNumericUpDn-InputBindingsManager-GetUpdatePropertySourceWhenEnterPressed-System-Windows-DependencyObject-'></a>
### GetUpdatePropertySourceWhenEnterPressed(dp) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dp | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') |  |

<a name='M-WPFNumericUpDn-InputBindingsManager-SetUpdatePropertySourceWhenEnterPressed-System-Windows-DependencyObject,System-Windows-DependencyProperty-'></a>
### SetUpdatePropertySourceWhenEnterPressed(dp,value) `method`

##### Summary

Update Property Source When Enter Pressed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dp | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') |  |
| value | [System.Windows.DependencyProperty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyProperty 'System.Windows.DependencyProperty') |  |

<a name='T-WPFNumericUpDn-IntegerNumber'></a>
## IntegerNumber `type`

##### Namespace

WPFNumericUpDn

##### Summary

a class represent a constrained integer number

<a name='M-WPFNumericUpDn-IntegerNumber-#ctor-System-Int32,System-Int32,System-Int32,System-Int32-'></a>
### #ctor(value,min,max,inc) `constructor`

##### Summary

construct an contrsianed integer

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| min | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| inc | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='P-WPFNumericUpDn-IntegerNumber-FormatString'></a>
### FormatString `property`

##### Summary



<a name='P-WPFNumericUpDn-IntegerNumber-_regex'></a>
### _regex `property`

##### Summary



<a name='M-WPFNumericUpDn-IntegerNumber-ConvertToValue-System-Int32@-'></a>
### ConvertToValue(result) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| result | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') |  |

<a name='M-WPFNumericUpDn-IntegerNumber-decrement'></a>
### decrement() `method`

##### Summary



##### Returns



##### Parameters

This method has no parameters.

<a name='M-WPFNumericUpDn-IntegerNumber-increment'></a>
### increment() `method`

##### Summary



##### Returns



##### Parameters

This method has no parameters.

<a name='T-WPFNumericUpDn-IntegerNumericControl'></a>
## IntegerNumericControl `type`

##### Namespace

WPFNumericUpDn

##### Summary

class represent the numeric up down control for integer type

<a name='M-WPFNumericUpDn-IntegerNumericControl-#ctor'></a>
### #ctor() `constructor`

##### Summary

represnet the integer number without constrain (default value 0)

##### Parameters

This constructor has no parameters.

<a name='T-WPFNumericUpDn-NumbericControl'></a>
## NumbericControl `type`

##### Namespace

WPFNumericUpDn

##### Summary

Interaction logic for UserControl1.xaml

<a name='M-WPFNumericUpDn-NumbericControl-#ctor'></a>
### #ctor() `constructor`

##### Summary

main constructor

##### Parameters

This constructor has no parameters.

<a name='M-WPFNumericUpDn-NumbericControl-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-WPFNumericUpDn-NumbericControl-Timer_Elapsed-System-Object,System-Timers-ElapsedEventArgs-'></a>
### Timer_Elapsed(sender,e) `method`

##### Summary

run the current command every 100 milliseconds

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Timers.ElapsedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Timers.ElapsedEventArgs 'System.Timers.ElapsedEventArgs') |  |

<a name='M-WPFNumericUpDn-NumbericControl-incBTN_MouseLeftButtonDown-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
### incBTN_MouseLeftButtonDown(sender,e) `method`

##### Summary

sets the command and starts the timer

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.MouseButtonEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseButtonEventArgs 'System.Windows.Input.MouseButtonEventArgs') |  |

<a name='M-WPFNumericUpDn-NumbericControl-incBTN_MouseLeftButtonUp-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
### incBTN_MouseLeftButtonUp(sender,e) `method`

##### Summary

stops the timer

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.MouseButtonEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseButtonEventArgs 'System.Windows.Input.MouseButtonEventArgs') |  |

<a name='M-WPFNumericUpDn-NumbericControl-textBox_PreviewTextInput-System-Object,System-Windows-Input-TextCompositionEventArgs-'></a>
### textBox_PreviewTextInput(sender,e) `method`

##### Summary

check if the content of the text box is valid. only if valid then it is pushed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.TextCompositionEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.TextCompositionEventArgs 'System.Windows.Input.TextCompositionEventArgs') |  |
