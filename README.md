# Group 19 Final Project - EZread
# Authors:	Darpal Patel
		Hassan Sohail
		Jonathan Cho
		Kevin Hoang
		Devon Tran
    
## How to run the project
1. Unzip the project folder and remember the path 
2. Launch Visual Studio 2022 and select "Open a project or solution"
3. Navigate to the project folder, open the test folder and select test.sln (test/test.sln)
4. Ensure that you have Blazorstrap.v5 installed in the project packages
5. Select the green play icon at the top of Visual Studios to run the project
6. A web browser will pop up displaying our online library system!
# Note: Make sure web browser is as large as possible, display may not adjust correctly to smaller screen sizes

## Cases for navigating the project

Case 1: Dynamically adding/removing books to your bag and being able to sign them out
    Step 1:  If not logged in click the login tab to bring you into the login page, if logged in skip step 2-4
    Step 2: Enter any numbers for the library card fill in
    Step 3: Enter any numbers for the PIN fill in
    Step 4: Click the login button in the login container
    Step 5: Click My Bag tab to see that there are no items in the bag currently
    Step 6: Click Home tab to return back to the homepage
    Step 7: Click on the book cover “My Secret Sister” to open up the pop up on book information
    Step 8: Click see more to expand the book description
    Step 9: Click add to bag 
    Step 10: Click the double arrow on the top left of the popup to close the popup
    Step 11: Click the book cover for “Can’t Hurt Me”
    Step 12: Click add to bag 
    Step 13: Click the double arrow on the top left of the popup to close the popup
    Step 14: Click the book cover for “Mad Honey”
    Step 15: Click add to bag 
    Step 16: Click the double arrow on the top left of the popup to close the popup
    Step 17: Click My Bag Tab on the nav menu
    Step 18: Click Remove for “My Secret Sister”
    Step 19: Click Home on the nav menu
    Step 20: Click the book cover for “Mad Honey”
    Step 21: Click the remove button on the pop up
    Step 22: Click the double arrow on the top left of the popup to close the popup
    Step 23: Click Bag on the nav menu
    Step 24: Click Complete Sign Out button
    Step 25: Click Confirm Sign Out button 


Case 2: Searching Books 
    Step 1: Go to the Homepage of the interface.
    Step 2: Click on the search bar at the top of the page to being searching.
    Step 3: Type in the word “Me” into the search bar.
    Step 4: Press the search button on the right of the search bar and the interface will redirect you to a page with the results of the search. The results of the search will be all the book titles with the word “Me” as a substring. So, for example the book “Homecoming” should show in the results. Also note, you don’t need to login to search books. 
    Step 5: You can now select any of the books shown on the search results page to view them and add to your bag.
    
Case 3: A dynamic notification system that displays important information and paying for outstanding fees

    Step 1: If not logged in click the login tab to bring you into the login page, if logged in skip step 2-4
    Step 2: Enter any numbers for the library card fill in
    Step 3: Enter any numbers for the PIN fill in
    Step 4: Click the login button in the login container
    Step 5: Click Home on the nav menu
    Step 6: See the warning underneath the nav menu on the top left
    Step 7: Hover over My Account Tab on nav menu
    Step 8: Click Payments on the drop down bar
    Step 9: Click Pay for the book “Outlive”
    Step 10: Click “Use Different Payment” 
    Step 11: Click “Use This”
    Step 12: Enter any three-digit number in the CVV section
    Step 13: Click Complete Payment at the Button of the pop-up
    Step 14: Click Home on the nav menu
    Step 15: See the warning underneath the nav menu on the top left and the value has been adjusted accordingly
    Step 16: On the red warning for the notifications underneath the nav menu click the hyper-link named “here” to redirect to the payments page
    Step 17: Click “Pay All” button in the red square with the total fees due
    Step 18: Enter name for Cardholder Name section
    Step 19: Enter any 16 Digit number in the Credit Card Number Section
    Step 20: Enter Any numbers for the expiry date for in format of MM/DD for the Expiry Date section
    Step 21: Enter any three-digit number in the CVV section
    Step 22: Enter any T3J5A8 in the postal code section
    Step 23: Click and select any country from the country drop down bar
    Step 24: Scroll down in the pop-up and click the complete payment button
    Step 25: Click the blue hyperlink that says “Home”
    
Case 4: Functionality to save any payment methods for future use on profile
    Step 1: If not logged in click the login tab to bring you into the login page, if logged in skip step 2-4
    Step 2: Enter any numbers for the library card fill in
    Step 3: Enter any numbers for the PIN fill in
    Step 4: Click the login button in the login container
    Step 5: Hover over My Account Tab on nav menu
    Step 6: Click Profile on the drop down bar
    Step 7: Click the plus symbol near the words “Add Payment Method”
    Step 8: Enter name for Cardholder Name section
    Step 9: Enter any 16 Digit number in the Credit Card Number Section
    Step 10: Enter Any numbers for the expiry date for in format of MM/DD for the Expiry Date section
    Step 11: Enter any three-digit number in the CVV section
    Step 12: Enter any T3J5A8 in the postal code section
    Step 13: Click and select any country from the country drop down bar
    Step 14: Click “Add Payment Method” Button
    Step 15: Repeat steps 7-14 to save another payment method
    Step 16: Click Remove card on one of the saved payment informations that you inputted 
    
Case 5: Dynamically adding/removing books on hold for future sign-out if unavailable.
 
    Step 1: If not logged in click the login tab to bring you to the login page. If you are logged in, then skip steps 2-4
    Step 2: Enter any number for the library card fill in.
    Step 3: Enter any number for the PIN fill in.
    Step 4: Click the login button at the bottom of the login container.
    Step 5: Click on the My Account tab on the navigation bar to open the dropdown bar.
    Step 6: In the dropdown bar under the My Account tab, find and click the on Hold tab.
    Step 7: Once the on Hold page opens, check if there are any books on hold. If there aren’t any books on Hold then proceed to the next step. Otherwise move on to step 14.
    Step 8: Go back to the homepage by clicking home on the navigation bar.
    Step 9: Once you are in the Homepage, browse the displayed books and look for the book “Old babies in the woods: Stories”.
    Step 10: Click on this book to open a popup, which shows the details of the selected book.
    Step 11: Once in this popup with the book displayed, press the Place On Hold button. The place on hold button will then change to a red Leave waitlist button instead, which can be used to remove the book from on Hold. This action can also be done on the on Hold screen itself.
    Step 12: Back out of the popup to the homepage by clicking the right arrow on the top left of the popup.
    Step 13: Go back to the on Hold page by using the My Account dropdown bar and the on Hold tab as previously done in step 6.
    Step 14: The on Hold page should display the book that you just placed on hold. It will also display where the book is, what position you are in the waitlist, other details of the book, and will have a red cancel button on the right.
    Step 15: Click the red cancel button on the right to remove the book from on Hold. The screen will remove the book “Old babies in the woods: Stories” from on hold.
    Step 16: Go back to the homepage by clicking home on the navigation bar.
    Step 17: Look for the same unavailable book “Old babies in the woods: Stories”.
    Step 18: Click on this book to open the popup from before. The Place On Hold button should now be available again. Click on this button to once again place the book on Hold.
