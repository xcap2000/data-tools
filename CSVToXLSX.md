# CSV to XLSX

## Requirements

* Create XLSX from CSV
* Use the CSV file name as XLSX file name
* If CSV file exceeds one million records ask user:
  * Split by spreadsheet
    * For Test.csv input the output would be Test-1.xlsx and sheets would be Test-1, Test-2 if bigger than ten million would be Test-01, Test-02 and so on.
    * Block user from splitting into the same excel file if we have too many records, that would probably crash or freeze excel. Test for a good limit that keeps excel sane.
  * Split by file
    * For Test.csv input the output would be Test-1.xlsx, Test-2.xlsx if bigger than ten million would be Test-01.xlsx, Test-02.xlsx and so on.
* Use producer/consumer.
* Show progress.
* Show estimated time.
* Allow cancellation.
* Validate file before trying to import.
* Create XLSX with text only.
* Detect data types for each column using all the rows.
* Detect wraper character (double quotes, single quotes etc.)
* Detect quotes fields and allow the user to change field names on the destination
* Allow removing Columns when converting.