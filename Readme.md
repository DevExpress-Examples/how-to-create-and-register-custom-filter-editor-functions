# How to Create and Register Custom Filter Editor Functions

This example illustrates how to create three custom functions:

* **NotBeginsWith** - a function opposite to the standard *BeginsWith* function.
* **IsDaysInterval** - checks whether a record belongs to the *“(Today - N days) ~ (Today + N days)”* timeframe.
* **IsWeekend** - shows only Saturday and Sunday records.

The sample also illustrates three ways you can register these functions. Depending on the registration type you use, the function's availabily may differ.

* The control's **QueryCustomFunctions** event - functions added on this event are available for this specific control only.
* The **CriteriaOperator.QueryCustomFunctions** event - registers global custom functions available for all Filter/FilterEditor Controls.
* The **DevExpress.Data.Filtering.CustomFunction** attribute in a data source class - a custom function registered by the attribute is available for all Filter/FilterEditor controls bound to this data source.
