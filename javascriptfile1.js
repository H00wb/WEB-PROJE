function submitter()
{
var name = document.getElementById('name').value;
var surname = document.getElementById('surname').value;
var email = document.getElementById('email').value;
var phone = document.getElementById('phone').value;
var genderm= document.getElementById('genderm');
var genderf= document.getElementById('genderf');
var gender= '';
if(genderf.checked)
{
    gender="Female";
}
else if(genderm.checked)
{
    gender="Male";
}

if (name == '' || surname == '' || email == '' || phone =='' || gender=='')
{
alert("Please fill the blank fields!");
}
else
{

alert("Name: " + name + " Surname: " + surname + "\n" + "Phone Number: " + phone + " Email: " + email + "\n" + "Gender: " + gender);
}
}
