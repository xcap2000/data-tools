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