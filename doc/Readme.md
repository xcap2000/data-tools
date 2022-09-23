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
Log using utc datetime and show acccording to user/windows preferences. Logs maybe synchronized with we application for
profiling, debugging etc.

Add command line interface and Console UI support like ncurses. 

Detect when OS is going to restart, resume all jobs, restart jobs if applications is setup to start with windows/user logon.

Allow users to define how many jobs run at the same time as well allow the user to reorder, i.e. If we allow 3 tasks at the same time if we exchange order 4 to 3, 3 job is paused and 4 job is resumed.


All operations can be resumed in:

Getting data from a data source (or multiple data sources) optionally change the data (enrich, remove columns, filter etc) and send to a destination or multiple destinations

Add a tool to execute sql scripts like the ones generated from sql server management studio/generate scripts, make showing progress optional but if it is selected show progress based on the counts of existing creates, inserts, updates etc. in the file.
Getting data from a data source (or multiple data sources) optionally change the data (data cleansing, data enriching, remove columns, filter etc) and send to a destination or multiple destinations

Allow data appending, add incremental data, choose to replace intersection with new or keep old by primary key.

When converting streaming, show the source and destination velocity like very slow, slow, normal, fast, very fast. Calculate based on time and or relative to the other side. Throttle the read and/or write queue to avoid big memory consumption. Allow queuing on disk if the data source is too slow or not stable like impala.

Create a tool to copy data from one machine to another using onedrive etc

Create tool to allow import of files using the database and shared driver like bulk insert from sql server, this way is much faster.

Allow concurrent operations, for example when importing a csv count the lines while importing and adjusting the progress accordingly.
Or before importing when counting records and analysing the fields or count records during import but with a timeout.

Copy/Paste/Duplicate table.

Create a tool to run queries with templates, where tables, fields and values could be provided from configuration

Create a tool to create queries visually like ms access have.

Make it possible for not using prepared statements, for simba spark driver for example it is must have as I was not able to use prepared statements at least for azure cloud version.

Query execution may take more time than retrieval and we should be able to report that the system is working on running the query so that the user does not think it is frozen or has crashed.

Create a tool to test connections, probably the connection manager will do it.

Save results to a temporary database when exporting to excel/csv or save frequently and return partial results when a problem ocurrs.

Save results to a different sheet (in case of excel) and/or file according to the distinct value of a field.
For example a query might return records from multiple "mandts" and each record will be saved to their own file, we can expand that
to a datetime field or a part of it like year, year+month, year+month+day etc or other data types. Check granularity in order not to generate too many files.

Allow users to define new columns names and use wrappers [] `` "" in case they use keywords as column names, each technology sql server, oracle etc use
their own wrappers and have their own keywords

Always be careful before deleting a file or table, maybe put them on the trash and/or schedule to remove
(there is a comment for the feature, delete after some days etc)

Create tools to do data analyses, identify source datatypes, granularity of values, percentage of values etc.

Create a tools that identifies possible joins (inner, left etc) possible fields, multiplicity 1x1, 1xmany, many to many etc.
Make it possible for SAP, maybe by column and table names previously mapped using sap table reference sites