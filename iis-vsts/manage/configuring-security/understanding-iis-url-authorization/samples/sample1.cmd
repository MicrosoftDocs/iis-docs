net user Alice <password_of_your_choice> /add
net user Bob <password_of_your_choice> /add
net user Fred <password_of_your_choice> /add
net localgroup BobAndFriends /add
net localgroup BobAndFriends Alice /add
net localgroup BobAndFriends Bob /add