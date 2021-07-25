#Jenkins pipeline syntax used for defining JenkinsFile.


Source(git): First, Write a code and send to repository. 

Build/package: Then it is triggered in a Build automation framework. When it is complete, it triggers a test automation framework where all are executed one-by-one. Once the test cases passes, the server will be configured.

Deploy: Then the Application package will be deployed on the service. 

pipeline {
    agent any

    tools {
        // Install the Maven version configured as "M3" and add it to the path.
        maven "M3"
    }

    stages {
        stage('Build') {
            steps {
                // Get some code from a GitHub repository
                git 'https://github.com/jglick/simple-maven-project-with-tests.git'

                // Run Maven on a Unix agent.
                sh "mvn -Dmaven.test.failure.ignore=true clean package"

                // To run Maven on a Windows agent, use
                // bat "mvn -Dmaven.test.failure.ignore=true clean package"
            }

            post {
                // If Maven was able to run the tests, even if some of the test
                // failed, record the test results and archive the jar file.
                success {
                    junit '**/target/surefire-reports/TEST-*.xml'
                    archiveArtifacts 'target/*.jar'
                }
            }
        }
    }
}



# SCA Cloud School Application Process
1. Created a cloud account with AWS free tier subscription.
2. Created an instance. 

![image](https://user-images.githubusercontent.com/54285015/126900449-6eeb6c63-a447-4c77-bcb8-8b5c8721cd6e.png)

3. Downloaded and installed Jenkins on my local machine to run on the default port 8080.

![image](https://user-images.githubusercontent.com/54285015/126900912-154097b1-2e5f-49ac-a43a-718ee2413966.png)

4. Created this SCA Cloud School Application repository Using a C# Number Guessing Game.

5. Setup a build job on Jenkins.

![image](https://user-images.githubusercontent.com/54285015/126900786-d579c93e-e545-4ae6-bd9a-3dde0a7a19a2.png)

6. Integrated my github repo to your Jenkins. Below is my Log and configuration screenshots.

![image](https://user-images.githubusercontent.com/54285015/126900707-55911510-39cb-4959-bfda-a5d34544069b.png)
![image](https://user-images.githubusercontent.com/54285015/126900732-fba0d99a-de53-48d8-b394-e759a2d74a90.png)

7. Url to access jenkin server.

http://localhost:8080/job/SCA%20cloud%20bootcamp%20Application/

Username: Oluwadolamipo 

Password:4Krist!!
