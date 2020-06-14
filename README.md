![alt text](https://media.discordapp.net/attachments/719985228805832744/721704602600210501/unknown.png)


# Brickster!

Brickster is a easy and Simple Brick-hill API Wrapper made in C#-

## Download Brickster

https://www.nuget.org/packages/Brickster/

![Nuget](https://img.shields.io/nuget/dt/Brickster?color=%23ff&label=Downloads&logo=C&logoColor=%23fff&style=plastic)


# Documentation

Documentation files made by Edge.

 - user
 - Shop
 - clan
 - games
 - Brick Hill Trade

**Note:** Documentation is still in development as the creator of brickster is adding features. Right now only User, Shop, and clan variables are working. Everytime the creator implements more classes and functions they will be added to the docs right away. Open an issue if you find a typo or a error!
### Starting the variables:

The API needs to load a few variables (This is purely for simplicity when programming)

User Variable:
```csharp
User usr = new User();
```
Shop variable:
```csharp
Shop shp = new Shop();
```
Clan variable:
```csharp
Clan cln = new Clan();
```

It's also required to install the Newtonsoft.Json NuGet package.
https://www.nuget.org/packages/Newtonsoft.Json/
Once installed you should be able to add this at the top of your code:
```csharp
using using Newtonsoft.Json;
```

---
### User Filter Arguments.
```csharp
public string username {set; get;}
public string id {set; get;}
public string last_online {set; get;}
public string created_at {set; get;}
public string img {set; get;}
```
### User Functions

UserDetails
  ```csharp
   public string UserDetails(int userId, string filtrer)
   ```
Get the Users Details trough their User ID and a Filtrer.
Filtrer Usages:

Example of Usage:

```csharp
string Edge = usr.UserDetails(298593, "username");
Console.WriteLine(Edge);
// Returns the username attached to the user id.
```
Output

`Edge.`

---

ToUsername 
  ```csharp
   public string ToUsername(int userId)
   ```
Get the Username Attached to the UserId.

Example of Usage:

```csharp
string Username = usr.ToUsername(298593);
Console.WriteLine(Username);
// Returns the username attached to the user id.
```
Output

`Edge.`

---

ToId 
  ```csharp
   public string ToId(string username)
   ```
Get the UserId Attached to that username.
Filtrer Usages:



Example of Usage:

```csharp
string id = usr.ToId("Edge.");
Console.WriteLine(id);
// Returns the id attached to the username.
```
Output

`298593`

---
### Shop Functions
#### Filter Arguments:
```csharp
public string name { get; set; }
public string description { get; set; } 
public string bits { get; set; }
public string bucks { get; set; }  
public string id { get; set; }
public bool is_special { get; set; }
public bool special_edition { get; set; } 
public bool special { get; set; } 
public string thumbnail { get; set; }

```
#### Shop Functions: 
GetLatest
  ```csharp
   public string GetLatest(string itemFilter, string detailFilter)
   ```


Example of Usage:

```csharp
string LatestShirt = shp.GetLatest("shirt", "bits");
string LatestShirtName = shp.GetLatest("shirt", "name");
Console.WriteLine("Latest Shirt Uploaded:\n");
Console.WriteLine("'"+LatesShirtName +  "` With a total value of: ");
Console.WriteLine(LatestShirt + " Bits");
// Returns the username and bits of the latest shirt uploaded.
```
Output

```
Latest Shirt Uploaded:
`Space Builder Jacket` With a total value of:
30 Bits
```
---
### Clan Arguments
```csharp
public string id {get; set;}
public string name {get; set;}
public string tag {get; set;}
public string creationdate {get; set;}
public string title {get; set;}
```
### Clan Functions
ClanInfo
  ```csharp
   public string ClanInfo(int id, string filter)
   ```
Get information about a clan.
Filtrer Usages:

 - id 
 - filter -- "id", "name", "tag", "creationdate", "title"


Example of Usage:

```csharp
string ClanName = cln.ClanInfo(3355, "name");
string ClanTag = cln.ClanInfo(3355, "tag");
string ClanCreation = cln.ClanInfo(3355, "creationdate");
Console.WriteLine("Clan Name: "+ClanName);
Console.WriteLine("Clan Tag "+ClanTag);
Console.WriteLine("Clan Creation Date :" + ClanCreation);
```
Output

```
Clan Name: Choco Gang
Clan Tag: CHC
Clan Creation Date: 06/12/2020
```
## Brick Hill Trade API
#### Brick Hill Trade Filter Arguments:
```csharp
public string value { get;  set; } 
public string average { get;  set; } 
public string rank { get;  set; } 
public string specials { get;  set; }
```
### Functions of Brick Hill Trade API.

---
# Credits

### Documentation made by Edge.
### Wrapper made by Boyscout
### Choco-Client Organization.
