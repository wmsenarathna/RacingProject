Racing Project

I developed a console application to complete the test.

When data modeling, I assumed all game's (Horse, GreyHounds and Harness) services could return same information (same XML input).

I have created an XML serializer and a json serialzer to extract data from the input. 
Xml serializer has been implemented as it possible to do schema validation in the future to get more accurate data.
Json serializer implemented to get json and publish internally.
I have not saved data in a database but implemented a layer for data access.

Before run the project, please update basePath "string basePath = "D:\\Racing Project\\Racing\\Services\\";" in ServiceHelper class. The basePath should be Services folder path in the project.

Thank you.
