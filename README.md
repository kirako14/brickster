# Brickster!

Brickster is a easy and Simple Brick-hill API Wrapper made in C#-

## Download Brickster
https://www.nuget.org/packages/Brickster/1.0.0#

![Nuget](https://img.shields.io/nuget/dt/Brickster?color=%23ff&label=Downloads&logo=C&logoColor=%23fff&style=plastic)


# Documentation

Documentation files made by Edge.

 - Brickster. V1 .User
 - Brickster. V1 .Shop
 - Brickster. V1 .Clan
 - Brickster. BHT .BHT
 - Brickster. V1 .Games

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

---
### User Functions

UserDetails
  ```csharp
   public string UserDetails(int userId, string filtrer)
   ```
Get the Users Details trough their User ID and a Filtrer.
Filtrer Usages:

 - username
 - id
 - last_online
 - created_at
 - img

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
Filtrer Usages:

 - id


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

 - username


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

GetLatest
  ```csharp
   public string GetLatest(string itemFilter, string detailFilter)
   ```
Get the latest item filtered.
Filtrer Usages:

 - ItemFilter -- "shirt", "pants", "tool", "tshirt", "hat".
 - detailFilter -- "bits", "bucks", "name"


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


---
# Credits

### Documentation made by Edge.
### Wrapper made by Boyscout
### Choco-Client Organization.
