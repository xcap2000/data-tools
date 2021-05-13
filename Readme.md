# Data Tools

The aim of this project is to create data related tools to import, export and convert data to and from diverse source and destinations.

Tool to remove columns from origin to destination.
Tool To Distinct, merge equal lines
Tool to split files by line using delimiter(s) or size
Tool to join files
When adding to database allow to add timestamp or transaction column so that we can delete if needed.
Allow the user to select transaction mode for resources that support it, per record, per block (each 10,000 records for instance), everything.
Collect data usage and metrics from end user in order to improve application.


---
Tool to remove files after a time like, delete em one week time, in two weeks time, in one month time etc.
This will check for files to remove on a daily basis...

Integrate test every tool with small, medium, big and huge files. Create a compressed format so that we can import and export bige and huge files.

While importing to and from to a database allow defining page size or with no page size, in the latter case stream the data and do not sort (this helps very much on impala)

Detect file encoding if possible and allow user to choose.
Datetime fields when detected allow the user to set the timezone.

Allow the users to pause the process or slow them down to save resources, warn about possible changes in the source data while pausing or paging etc. Allow pause and resume even after restart.

Allow backup for destructive actions and or patch creation, examples when regexing a file.

Tool to remove lines from a file based on a criteria, field A >= '2019-01-01' and A <= '2019-01-31'
Tool to edit a line
Tool to replace text, replace by regex
Tool to count, average etc values from text

For impala it is better to filter on a specific date than to do limit and offset, limit and offset is very poor in performance due to sorting. That is why I got the application stuck. Make the application able to stream all the data or configure it to calculate date intervals like day by day, weekly, two weeks, month by month, the application can calculate that automatically based on the amount of records found in a day by day basis and the time taken.

Make a tool to compare columns of data in excel, print yellow the differences, or make data-tools able to do the comparison, allow similar comparison and show the percentage of how equals the texts are, some descriptions have encoding issues.


Create tool to synchronize different databases. Allow the tool to identify the relations and synchronize just a subset of the data based on a date criteria for example.


When comparing the files allow ignoring columns, configure case comparison etc. Allow the user to select what they want 'Exists in first', 'Exists in second', 'Field values don't match', 'Equals'.

When analysing allow the user to use or define TQT rules.

Implement a way to do standard deviation.

Get some user info and send to me like username, e-mail, machine name.

Create own format to "export to sql" but instead creating sql create a small file with description of fields and types and allow import into different databases.

Test with different database technologies in different versions, document every supported database.

Implement log, allow. Maybe use sqlite with compressed database to hold data and/or to hold configuration, job information.

Add command line interface and Console UI support like ncurses. 

Detect when OS is going to restart, resume all jobs, restart jobs if applications is setup to start with windows/user logon.

Allow users to define how many jobs run at the same time as well allow the user to reorder, i.e. If we allow 3 tasks at the same time if we exchange order 4 to 3, 3 job is paused and 4 job is resumed.


All operations can be resumed in:

Getting data from a data source (or multiple data sources) optionally change the data (enrich, remove columns, filter etc) and send to a destination or multiple destinations