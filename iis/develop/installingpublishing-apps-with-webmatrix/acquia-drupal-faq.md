---
title: "Acquia Drupal FAQ"
author: rick-anderson
description: "WebMatrix Beta supports installing open source community applications from the Web Application Gallery, and publishing to hosting providers, including a set..."
ms.date: 07/06/2010
ms.assetid: fa41913f-66c4-4ace-9312-bfd55679c7bf
msc.legacyurl: /learn/develop/installingpublishing-apps-with-webmatrix/acquia-drupal-faq
msc.type: authoredcontent
---
Acquia Drupal FAQ
====================
by Faith A

WebMatrix Beta supports installing open source community applications from the Web Application Gallery, and publishing to hosting providers, including a set of Beta partner hosting providers. This FAQ contains information about installing and publishing, as well as any issues that may occur after publishing.

## Installing and Publishing Acquia Drupal

#### Q: How do I install Acquia Drupal?

A: To install Acquia Drupal, use the following steps:

1. Open WebMatrix Beta and select **Site from Web Gallery**.
2. Select the **CMS** category on the left-hand side.
3. Find **Acquia Drupal** in the list and install it.
4. In any workspace, on the **Home** tab, in the **Site** group, click **Run** or press F12 to open the site in your default web browser.
5. Follow the instructions to complete installation.
6. Note: If you use a database name, username or password that contains certain special characters, you will receive an error when browsing to the application. Follow the workaround listed below..

#### Q: How do I publish my Acquia Drupal website?

A: To publish a Acquia Drupal website, use the following steps:

1. In any workspace, on the **Home** tab, in the **Site** group, click **Publish**.
2. On the **Publishing Settings** dialog, enter the server info you received from your web host.
3. Click **Validate Connection** to ensure that the settings are correct.
4. Click **Publish**.
5. If you have not published your database before, select the Database checkbox.
6. After previewing the changes, click **Continue**.

## Common Issues

#### Q: Why do I get a "The service is unavailable" error when browsing to the website?

A: You will see this error if you are publishing to a database server where the database name, username or password contains the following special characters:

[!code-console[Main](acquia-drupal-faq/samples/sample1.cmd)]

This is because those characters are used by the application to parse the file, so it fails unless the characters are escaped properly.

To resolve this issue, it is recommended that you use your hosting control panel to change your password to one without the special characters.

If this is not possible, you can workaround the issue by creating a copy of the *settings.php* that will be used for the remote web site:

1. Go to the **Files** workspace.
2. Navigate to the /sites/default folder.
3. Copy and paste the *settings.php* file to create a copy.
4. Rename the *settings - Copy.php* file to *settings.php.local*.
5. Open *settings.php* and find the line that begins with. 

    [!code-powershell[Main](acquia-drupal-faq/samples/sample2.ps1)]
6. Change the line to escape special characters, you will find the hex replacements listed in *settings.php*.  
  
	For example, change the following line:

    [!code-powershell[Main](acquia-drupal-faq/samples/sample3.ps1)]

	to:

    [!code-powershell[Main](acquia-drupal-faq/samples/sample4.ps1)]
7. Click **Save** on the **Quick Access Toolbar** or press Ctrl + S.
8. Using a text editor, modify the WebMatrix Beta parameters file so that the Publish will not incorrectly replace this value: 

    1. In Windows Explorer, navigate to %userprofile%\appdata\
    2. First, make a copy of the *parameters.xml* file as a backup.
    3. Open *parameters.xml* in a text or XML editor.
    4. Find the below lines:  

        [!code-xml[Main](acquia-drupal-faq/samples/sample5.xml)]
    5. Comment out the &lt;parameterEntry&gt; line:  

        [!code-xml[Main](acquia-drupal-faq/samples/sample6.xml)]
    6. Save the changes to the file.
    7. Publish again.
    8. After publishing, browse to your remote web site to verify that the application works.
9. To switch to the local *settings.php* so that the application works on your client machine: 

    1. Rename *settings.php* to *settings.php.remote*.
    2. Rename *settings.php.local* to *settings.php*.
    3. Click **Run** or press F12 to open the site in your default web browser.
10. You will need to switch these files every time you publish.
