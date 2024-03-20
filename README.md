# Parks Lookup

#### By Aidan Williams

## Technologies Used

* _C#_
* _.NET_

## Description

A collection of API endpoints for looking up state and national parks.

1. `GET https://localhost:5001/api/Parks`

    Returns a list of parks.

2. `GET https://localhost:5001/api/Parks/{id}`

    Returns the message specified by a parkId.

    Example: `https://localhost:5001/api/Parks/1`

3. `POST https://localhost:5001/api/Parks`

    Posts a new message. Requires a request body containing the field values for the new park.

    Example:

    `{
      "name": "string",
      "type": "string",
      "location": "string"
    }`

4. `PUT https://localhost:5001/api/Parks/{id}`

    Edits the message specified by an ID. Requires a request body containing the edited field values for the message.

    Example request URL: `https://localhost:5001/api/Parks/1/`

    Example request body:

    `{
      "parkId": 0,
      "name": "string",
      "type": "string",
      "location": "string"
    }`

5. `DELETE https://localhost:5001/api/Parks/{id}`

    Deletes the message specified by an ID.

    Example: `DELETE https://localhost:5001/api/Parks/1/`

6. `GET https://localhost:5001/api/Parks/RandomPark`

    Returns a random park.

7. `GET https://localhost:5001/api/Parks/Search/{name}`

    Returns park(s) with a name containing the string specified by a parameter.

    Example: `https://localhost:5001/api/Parks/Search/smoky`

CORS is enabled for this API, allowing users to make requests from a domain other than the one this project is running on.

## Setup Instructions

1. Clone this repo.
2. Navigate to this project's production directory.
    1. Create a file called "appsettings.json"
    2. Add the following code to the file (username and password credentials are for your local server):
    
        `{
          "ConnectionStrings": {
            "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DATABASE-NAME];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
          }
        }`
3. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory.
4. Run `dotnet ef database update` in the command line.
5. Run `dotnet run` in the command line.
6. Visit https://localhost:5001/ in your web browser.
7. Optionally, you can run `dotnet build` to compile this website without running a local server.

## Known Bugs

* _No known bugs._

## License

_[GPL](https://en.wikipedia.org/wiki/GNU_General_Public_License)_

Copyright (c) _2023_ _Aidan Williams_