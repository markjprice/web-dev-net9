**Troubleshooting SQL Edge container issues**

- [Incorrect Username or Password](#incorrect-username-or-password)
- [Container Initialization Issue](#container-initialization-issue)
- [Container Not Running](#container-not-running)
- [Incorrect Connection String](#incorrect-connection-string)
- [Firewall or Network Configuration](#firewall-or-network-configuration)
- [Password Expiry or Account Lockout](#password-expiry-or-account-lockout)
- [Missing or Incomplete Environment Variables](#missing-or-incomplete-environment-variables)
- [Case-Sensitivity](#case-sensitivity)
- [Inspect Docker Logs for More Clues](#inspect-docker-logs-for-more-clues)
- [Additional Steps to Troubleshoot](#additional-steps-to-troubleshoot)
- [Recreate the Container if Needed:](#recreate-the-container-if-needed)

The error "Login failed for user 'SA'" occurs when the SQL Server cannot authenticate the login credentials you're using. This issue is common when connecting to Azure SQL Edge in a Docker container, as there are several potential misconfigurations. 

# Incorrect Username or Password

The default username for SQL Server is `SA`, but the password needs to meet specific requirements.

When creating the Docker container, you likely set the password using the `SA_PASSWORD` environment variable.

SQL Server passwords must:
- Be at least 8 characters long.
- Contain a mix of uppercase letters, lowercase letters, numbers, and symbols.

Ensure the password you are using matches the one you provided when the container was created. If you are unsure, recreate the container with a new password:

# Container Initialization Issue

If the container failed to initialize properly, the `SA` user might not be fully set up yet.

You can check the container logs for any errors during initialization:

```bash
docker logs azuresqledge
```

Look for any errors or issues in the logs. If you see issues related to the SA_PASSWORD, recreate the container with a valid password.

# Container Not Running

If the container is not running, your connection will fail.

Check the status of the container:

```bash
docker ps -a
```

If the container is not running, start it:

```bash
docker start azuresqledge
```

# Incorrect Connection String

Verify that the connection string you're using is correct. It should look like this:
```
Server=127.0.0.1,1433;Database=master;User Id=SA;Password=YourPassword123!;Encrypt=true;TrustServerCertificate=True;
```

Common mistakes:
- Using the wrong port (`1433` is the default for SQL Server).
- Using `127.0.0.1` when Docker is configured with a different network. Try replacing the IP address `127.0.0.1` with `localhost`.
- Misspelling `localhost` or using an incorrect hostname.

Ensure your connection string matches the credentials and host details of your container.

# Firewall or Network Configuration

If you are accessing the SQL Edge database from outside the Docker host, ensure the Docker container's port (`1433`) is exposed and not blocked by a firewall.
Also, check Docker’s network settings if you are using a custom network.

Confirm that port `1433` is accessible:

```bash
docker inspect azuresqledge
```

Look under the **Ports** section to ensure `1433` is mapped to the host.

# Password Expiry or Account Lockout

The SA account can get locked after multiple failed login attempts or if the password expires.

Unlock the SA account by connecting to the database using another admin user or via SQLCMD inside the container.

Run the following SQL command:

```sql
ALTER LOGIN SA WITH PASSWORD = 'YourNewPassword123!';
ALTER LOGIN SA ENABLE;
```

# Missing or Incomplete Environment Variables

If you didn’t pass the required environment variables when creating the container, SQL Edge may not have properly configured the SA account.

Ensure the `ACCEPT_EULA` and `SA_PASSWORD` environment variables are set when running the container:

```bash
docker run --cap-add SYS_PTRACE -e 'ACCEPT_EULA=1' -e 'MSSQL_SA_PASSWORD=s3cret-Ninja' -p 1433:1433 --name azuresqledge -d mcr.microsoft.com/azure-sql-edge
```

# Case-Sensitivity

SQL Server is case-sensitive when it comes to usernames and passwords, depending on the collation settings. Double-check that you are using the correct case for the username (SA) and password.

# Inspect Docker Logs for More Clues

The logs can give you valuable insight into what might be wrong:

```bash
docker logs azuresqledge
```

Look for errors related to the SA account, password policy violations, or database initialization failures.

# Additional Steps to Troubleshoot

Test Connection with SQLCMD (Inside Container):

To ensure the database is running and accessible, you can test it directly within the container:
```bash
docker exec -it azuresqledge /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P 's3cret-Ninja'
```

If this works, the issue is likely with your external connection string or networking.

# Recreate the Container if Needed:

If you suspect something went wrong during setup, stop and remove the container, then recreate it:
```bash
docker stop azuresqledge
docker rm azuresqledge
docker run --cap-add SYS_PTRACE -e 'ACCEPT_EULA=1' -e 'MSSQL_SA_PASSWORD=s3cret-Ninja' -p 1433:1433 --name azuresqledge -d mcr.microsoft.com/azure-sql-edge
```
