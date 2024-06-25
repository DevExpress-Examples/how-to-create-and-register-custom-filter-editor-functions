<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/189577113/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828688)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# How to Create and Register Custom Filter Editor Functions

This example illustrates how to create three custom functions:

* **NotBeginsWith** - a function opposite to the standard *BeginsWith* function.
* **IsDaysInterval** - checks whether a record belongs to the *“(Today - N days) ~ (Today + N days)”* timeframe.
* **IsWeekend** - shows only Saturday and Sunday records.

The sample also illustrates three ways you can register these functions. Depending on the registration type you use, the function's availabily may differ.

* The control's **QueryCustomFunctions** event - functions added on this event are available for this specific control only.
* The **CriteriaOperator.QueryCustomFunctions** event - registers global custom functions available for all Filter/FilterEditor Controls.
* The **DevExpress.Data.Filtering.CustomFunction** attribute in a data source class - a custom function registered by the attribute is available for all Filter/FilterEditor controls bound to this data source.
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-create-and-register-custom-filter-editor-functions&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-create-and-register-custom-filter-editor-functions&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
