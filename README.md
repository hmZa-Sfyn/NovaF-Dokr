<br>
<br>

<h1 style="text-align:center;">NovaF-Dokr</h1>
<h3 style="text-align:center;">Is A New Type Of Network Interface</h3>

<p style="text-align:center;">
    A <strong>custom network interface</strong> designed with unique
    protocols and procedures,
    tailored specifically to serve its own set of applications. Built 
    upon the powerful foundation of the <strong>Vin Virtual OS</strong>,
    this interface brings
    flexibility and control to modern network operations.
</p>

<img src="./ing1.png"></img>

<br>
<br>

<img src="./image.png"></img>

<br>
<br>

<img src="./ing2.png"></img>

## Version 1.4.9 (5/11/2024) Uploaded On (5~6/11/2024)

> ### **Dont expect me:** to post anathor version untill ```june-2025```

## **Added some system resource management commands:**
| Command                                                            | Description                                                                                                      | Imp |
|--------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------|-----|
| **@sres**                                                          | To manage system resources.                                                                                      |     |
| `@sres /pointers /help`                                            | For this help message.                                                                                           |  Y  | 
| `@sres /pointers :pointer/path`                                    | To access that pointer obj (not a string value or a path, just a obj).                                           |  Y  |
| **Advanced:**                                                      |                                                                                                                  |     |
| `@sres /pointers :pointer/path.function_or_arg($more_variables)`   | To get that pointer obj and perform `function_or_arg($more_related_stuff)` with that obj.                        |  Y  |
| `@sres /pointers /list`                                            | To list all pointers with parent path. (`root/path`)                                                             |  Y  |
| `@sres /pointers /clear`                                           | To clear the pointer dict.                                                                                       |  Y  |
| `@sres /pointers /save $file/path`                                 | To save current pointer dict to `$file/path`, which should be a `.pointers.vin` file.                            |  Y  |
| `@sres /pointers /save /nerv $file/path`                           | To save current pointer dict to `$file/path`, if `$file/path` does not exist, then just create one.              |  Y  |
| `@sres /pointers /load $file/path`                                 | To load pointers from `$file/path`, which should be a `.pointers.vin` file.                                      |  Y  |

## **More:**

```shell
anonymous@kernal::G:\s-cat\fri3nds\v-category-projects\Developer-Grade-Virtual-OS\Novaf-Dokr\Novaf-Dokr\bin\Debug\net8.0 % @sres /config /help

System Config: (the only fun part!)

 Config: are those system properties which can make your experiance more better (or worsen it), just by creating some embedded config files according to your needs.
  xMake: is the default configuration language for `vin_env` config files. (python support will come soon, wait...)

 Help:
  @sres /config /help             -> For this help message.
 Advanced:
  @sres /config /files /list      -> To list all config files. (weather enabled or disabled)
                  /files /+ $file/path -> To add a new config file. (type: `@sres /config /files /+` for manual adding, and this is more easy!)
                  /files /- $file/path -> To delete a config file.
  @sres /config /apply $file/path -> To apply config data present in `$file/path`.
```

> ## **Mission/Target** for version 1.4.9.x: `To make this to accept configuration files and more customization and resources management related stuff!`
> ## **Changes** made in 1.4.9.x: `Changed the input style, added` **CTRL+C** `control, and fixed @exit command, such that when you press CTRL+C it does not exit, when you type @exit, it does.`
                                   

## Version 1.1.0 (5/10/2024) Uploaded On (5~8/10/2024)

**Added some network and user commands:**

## **User Commands**

| Command                 | Description                                                                 | Imp |
|-------------------------|-----------------------------------------------------------------------------|-----|
| **@user**               | To manage users.                                                            |     |
| `@user list`            | To list all users.                                                          |  Y  |
| `@user add`             | To add a new user.                                                          |  Y  |
| `@user remove`          | To remove a user.                                                           |  Y  |
| `@user login`           | To login as a user.                                                         |  Y  |
| `@user logout`          | To logout from the current user and login as Guest.                         |  Y  |
| **More: (tier-2)**      |                                                                             |     |
| `@user name`            | To print the current username.                                              |  Y  | 
| `@user node-name`       | To print the current node name.                                             |  Y  |

### **Command Details**

1. **List Users**
   - **Command**: `@user list`
   - **Description**: Lists all the users currently in the system.
   - **Example**:
     ```bash
     @user list
     ```
   
2. **Add a User**
   - **Command**: `@user add <username> <password> <group>`
   - **Description**: Adds a new user with a username, password, and group.
   - **Example**:
     ```bash
     @user add john123 Passw0rd! guest
     ```
   - **Arguments**:
     - `<username>`: The username (3-20 characters)
     - `<password>`: The password (minimum 8 characters)
     - `<group>`: The user's group, e.g., `root`, `guest`, or `tmp`

3. **Remove a User**
   - **Command**: `@user remove <username>`
   - **Description**: Removes an existing user from the system.
   - **Example**:
     ```bash
     @user remove john123
     ```

4. **Login as a User**
   - **Command**: `@user login <username> <password>`
   - **Description**: Logs in with a specified username and password.
   - **Example**:
     ```bash
     @user login john123 Passw0rd!
     ```

5. **Logout**
   - **Command**: `@user logout`
   - **Description**: Logs out from the current user session and switches to Guest.
   - **Example**:
     ```bash
     @user logout
     ```

---

## **f-Net Commands**

| Command                 | Description                                                                 | Imp |
|-------------------------|-----------------------------------------------------------------------------|-----|
| **@fnet**               | To manage network nodes and systems.                                        |     |
| `@fnet list`            | To list all running nodes in your network.                                  |  Y  |
| `@fnet add`             | To add a new node in your system.                                           |  Y  |
| `@fnet remove`          | To remove a node from your system.                                          |  Y  |
| `@fnet login`           | To login to a node, either in your system or network.                      |  Y  |
| `@fnet logout`          | To logout from the current node and login to `127.0.0.1`.                   |  Y  |
| **More: (tier-2)**      |                                                                             |     |
| `@fnet node go-live`    | To publish a specific node or multiple nodes in your network.               |  Y  |
| `@fnet node shutdown`   | To shutdown a node in your network.                                         |  Y  |
| `@fnet node update`     | To update a node that you published or own.                                 |  Y  |
| `@fnet node stats`      | To view the stats of a specific node.                                       |  Y  |

### **Command Details**

1. **List Network Nodes**
   - **Command**: `@fnet list`
   - **Description**: Lists all running nodes in your network.
   - **Example**:
     ```bash
     @fnet list
     ```

2. **Add a Node**
   - **Command**: `@fnet add <nodename> <path> <port>`
   - **Description**: Adds a new node to your system with a name, path to its API script, and port.
   - **Example**:
     ```bash
     @fnet add node01 /api/script.py 5000
     ```
   - **Arguments**:
     - `<nodename>`: Name of the new node
     - `<path>`: Path to the Python Flask API script
     - `<port>`: Port number for the node

3. **Remove a Node**
   - **Command**: `@fnet remove <nodename>`
   - **Description**: Removes a node from your system.
   - **Example**:
     ```bash
     @fnet remove node01
     ```

4. **Login to a Node**
   - **Command**: `@fnet login <nodename> <username> <password>`
   - **Description**: Logs into a specific node in your system or network.
   - **Example**:
     ```bash
     @fnet login node01 admin Passw0rd!
     ```

5. **Logout from a Node**
   - **Command**: `@fnet logout`
   - **Description**: Logs out from the current node and switches to `127.0.0.1`.
   - **Example**:
     ```bash
     @fnet logout
     ```

6. **Publish a Node**
   - **Command**: `@fnet node go-live <nodename>`
   - **Description**: Publishes a specific node in your network.
   - **Example**:
     ```bash
     @fnet node go-live node01
     ```

7. **Shutdown a Node**
   - **Command**: `@fnet node shutdown <nodename>`
   - **Description**: Shuts down a specific node in your network.
   - **Example**:
     ```bash
     @fnet node shutdown node01
     ```

8. **Update a Node**
   - **Command**: `@fnet node update <nodename>`
   - **Description**: Updates a node you own or have published in your network.
   - **Example**:
     ```bash
     @fnet node update node01
     ```

9. **View Node Stats**
   - **Command**: `@fnet node stats <nodename>`
   - **Description**: Views the stats of a specific node.
   - **Example**:
     ```bash
     @fnet node stats node01
     ```

## **Request Commands (req)**

| Command                      | Description                                                                 | Imp |
|------------------------------|-----------------------------------------------------------------------------|-----|
| **@req**                     | To manage HTTP requests and interactions with URLs.                         |     |
| `@fnet req get`              | Perform a GET request to fetch data from the specified URL.                  |  Y  |
| `@fnet req post`             | Perform a POST request to send data to the specified URL.                    |  Y  |
| `@fnet req put`              | Perform a PUT request to update data at the specified URL.                   |  Y  |
| `@fnet req delete`           | Perform a DELETE request to remove resources at the specified URL.           |  Y  |
| `@fnet req list`             | List all possible paths available for requests.                             |  Y  |

### **Options**

- `--show-content` : Display the response content after the request is made.
- `--threads <number>` : Specify the number of concurrent requests to make.
- `--retry-on-fail <number>` : Set the number of retry attempts on failure.

### **Examples**

```bash
@fnet req get http://example.com
@fnet req post http://api.example.com/data --show-content
@fnet req get http://test.com --threads 5 --retry-on-fail 3
@fnet req put http://api.example.com/update --show-content
@fnet req delete http://api.example.com/resource/123
```


## Version 0.1.0 (5/10/2024) Uploaded On (5~8/10/2024)

- **Added some network and user commands:**
- Fixed bugs.
- Added functionality.


<br>
<br>

# What is `f-Net`? 🌐🚀

> **f-Net** is a cutting-edge network protocol designed by developers, for developers. It's still under construction, but once it's live, it's going to shake things up and rock the internet!  Stay tuned for a revolution in network technology! 🌟


## **f-Net Protocols**
| Protocol           | Description                                                                             | Imp |
|--------------------|-----------------------------------------------------------------------------------------|-----|
| `fri3ndly_network` | A simple friendly testing ground for fellow devs.                                       |  Y  |
| `ApiNet`           | A simple Api-Friendly network built for APIs.                                           |  n  |
| `StDtTr`           | A simple For-Media-Storage network built for fast data transfers.                       |  n  |
| `SecureXNet`       | A protocol for securing sensitive data in transit with high-level encryption.           |  n  |
| `CloudShareNet`    | Optimizes data exchanges across cloud platforms for syncing and collaboration.          |  n  |
| `GameStreamNet`    | A real-time data transmission protocol optimized for gaming and video streaming.        |  n  |
| `DeviceSyncNet`    | A protocol for syncing data across IoT devices with efficient command processing.       |  n  |
| `DataMeshNet`      | Decentralized data handling and storage protocol using mesh network concepts.           |  n  |

## **f-Net Modules**
| Module          | Description                                                                                | Imp |
|-----------------|--------------------------------------------------------------------------------------------|-----|
| `QoSControl`    | Manages Quality of Service to prioritize network traffic and ensure reliable performance.    |  n  |
| `CacheBoost`    | A caching mechanism to optimize data storage and retrieval, reducing repeated network calls. |  n  |
| `AutoScaleNet`  | Dynamically scales network resources based on traffic volume for efficient performance.      |  n  |
| `NetMonitor`    | Monitors network performance, logs errors, and sends alerts for performance and security.    |  n  |

# **Note:** 📢

> ## `The f-Net will is implemented in version 1.0` 🚀




# **Community Contribution Needed!** 🤝

> ## `I need your support` and contributions to make this project even better! `Your ideas, feedback, and help are invaluable to us`. Together, we can create something amazing! 🌟

# **Contribution Guidelines:** 📜

> ## `There are no limits to what you can publish!` Feel free to contribute anything that you think will be helpful to the project. Whether it's a penetration testing module, network interface configurations, or any other network-related enhancements, all `contributions are welcome!` 🚀
