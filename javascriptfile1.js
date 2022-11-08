function submitter()
{
var name = document.getElementById('name').value;
var surname = document.getElementById('surname').value;
var email = document.getElementById('email').value;
var phone = document.getElementById('phone').value;

if (name == '' || surname == '' || email == '' || phone =='')
{
alert("Please fill the blank fields!");
}
else
{
alert("Name: " + name + " Surname: " + surname + "\n" + "Phone Number: " + phone + " Email: " + email);
}

}
