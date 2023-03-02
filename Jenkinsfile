pipeline{
    agent any
    triggers
    {
        pollSCM("* * * * *")
    }

    stages{
        stage("BUILD"){
            steps{

                sh "dotnet build CalculatorPipeline.sln"
            }
            post{
                always{
                    echo "========always========"
                }
                success{
                    echo "========A executed successfully========"
                }
                failure{
                    echo "========A execution failed========"
                }
            }
        }

        stage("TEST")
        {
            steps{
                sh "dotnet test"
            }
            
        }

        stage("DEPLOY")
        {
            steps{
                echo "DEPLOY!!!"
            }
            
        }
    }
    post{
        always{
            echo "========always========"
        }
        success{
            echo "========pipeline executed successfully ========"
        }
        failure{
            echo "========pipeline execution failed========"
        }
    }
}