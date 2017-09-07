<Query Kind="Statements">
  <Connection>
    <ID>d4403909-efff-4fbc-ac96-710a7b177f27</ID>
    <Persist>true</Persist>
    <Server>PAULKOLOZSVD2AE\SQL2008STANDARD</Server>
    <Database>ClientConfig</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

User user0 = new User()
{
	UserId = Guid.NewGuid(),
	UserName = "paulk",
	Password = "27830529",
	RoleId = 7,
	Name = "Paul",
	Surname = "Kolozsvari",
	Email = "paulkolo@gmail.com",
	DateCreated = DateTime.Now,
	Phone = "0833958283"
};
Users.InsertOnSubmit(user0);
SubmitChanges();

Users.Dump();