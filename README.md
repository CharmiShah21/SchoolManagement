# SchoolManagement
# About Website
SchoolManagement website is all about basic school site in which students can take a look for suitable courses, fees and allocated instructors.
In this website many different authentications and authorizations are implemented.
For example Login Authentication and limitations for Admin and user accounts.


### Screenshots of design view of tables and webpages.

![Screenshot (174)](https://user-images.githubusercontent.com/65780191/88447674-ea56c400-ce03-11ea-9c0b-13bd64859236.png)
![Screenshot (175)](https://user-images.githubusercontent.com/65780191/88447675-ea56c400-ce03-11ea-9349-42cd64d5d580.png)
![Screenshot (176)](https://user-images.githubusercontent.com/65780191/88447676-ea56c400-ce03-11ea-828f-85c11420f111.png)
![Screenshot (177)](https://user-images.githubusercontent.com/65780191/88447677-eaef5a80-ce03-11ea-9dc2-4743ee2e5024.png)
![Screenshot (178)](https://user-images.githubusercontent.com/65780191/88447678-eaef5a80-ce03-11ea-86c4-c6d9882ead6c.png)
![Screenshot (179)](https://user-images.githubusercontent.com/65780191/88447679-eaef5a80-ce03-11ea-8526-f7a4196b13b2.png)
![Screenshot (180)](https://user-images.githubusercontent.com/65780191/88447680-eaef5a80-ce03-11ea-9956-f6ff53f912e5.png)
![Screenshot (181)](https://user-images.githubusercontent.com/65780191/88447681-eb87f100-ce03-11ea-81c1-1501acc35c9b.png)
![Screenshot (183)](https://user-images.githubusercontent.com/65780191/88447682-eb87f100-ce03-11ea-96d5-73962f3f4c80.png)
![Screenshot (184)](https://user-images.githubusercontent.com/65780191/88447683-eb87f100-ce03-11ea-8020-e78235518848.png)

![Screenshot (185)](https://user-images.githubusercontent.com/65780191/88448045-8d5d0d00-ce07-11ea-86b1-a04993738b81.png)
![Screenshot (186)](https://user-images.githubusercontent.com/65780191/88448046-8d5d0d00-ce07-11ea-9ab9-e0f0301abd19.png)
![Screenshot (187)](https://user-images.githubusercontent.com/65780191/88448047-8d5d0d00-ce07-11ea-9fe7-2d72776aee62.png)
![Screenshot (188)](https://user-images.githubusercontent.com/65780191/88448048-8d5d0d00-ce07-11ea-87ab-783593cf4803.png)


# Q-1. Authorize minimum 1 action result in a controller
# Ans : As you login with admin account you cannot access to privacy page as it is authorized only to user account so it will show access denied.

# Q-2. Hide minimum 2 Links based on role 
# Ans : As you login with Admin all the links will be visible in navigation bar and can access all the pages home, courses, create role, Role list, fees and instructor except for privacy.therefore all the links are visible and accessible
except privacy.
But if you login with user account you can only see home, privacy and courses links none other links will visible to user as create role, Role list, fees and instructor are hide
for user account.
Also you can only create roles and see role list if you logged in with Admin account it will not visible if you logged in with user account.

# Q-3.  Authorize by multiple roles on a controller
# Ans : As if you login with Admin you can edit, update and delete data of courses, fees and Instructor pages but if you login with User account it wont display any create
,edit and delete button and you cannot access thoes functions.
