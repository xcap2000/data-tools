# Data Tools

The aim of this project is to create data related tools to import, export and convert data to and from diverse source and destinations.

Tool to remove columns from origin to destination.
File To Distinct, merge equal lines
Tool to split files
When adding to database allow to add timestamp or transaction column so that we can delete if needed.


---
Tool to remove files after a time like, delete em one week time, in two weeks time, in one month time etc.
This will check for files to remove on a daily basis...

Integrate test every tool with small, medium, big and huge files. Create a compressed format so that we can import and export bige and huge files.

While importing to and from to a database allow defining page size or with no page size, in the latter case stream the data and do not sort (this helps very much on impala)

Detect file encoding if possible and allow user to choose.
Datetime fields when detected allow the user to set the timezone.

Allow the users to pause the process or slow them down to save resources, warn about possible changes in the source data while pausing or paging etc.

Tool to remove lines from a file based on a criteria, field A >= '2019-01-01' and A <= '2019-01-31'
Tool to edit a line
Tool to replace text, replace by regex
Tool to count, average etc values from text

For impala it is better to filter on a specific date than to do limit and offset, limit and offset is very poor in performance due to sorting. That is why I got the application stuck. Make the application able to stream all the data or configure it to calculate date intervals like day by day, weekly, two weeks, month by month, the application can calculate that automatically based on the amount of records found in a day by day basis and the time taken.

Make a tool to compare columns of data in excel, print yellow the differences, or make data-tools able to do the comparison, allow similar comparison and show the percentage of how equals the texts are, some descriptions have encoding issues.