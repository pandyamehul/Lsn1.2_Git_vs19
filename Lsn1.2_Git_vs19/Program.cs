using System;

namespace Lsn1._2_Git_vs19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! - Welcom to the Git");

            //Step# 2 - File Edited on GitHub online in the master branch. 16-May-2020 18:49 CET. In this step from visual studio to make local branch sync with master branch - Fetch was used and then merged "master" with "origin/master" from visual studio.

            //Step# 2.1 - Changes are done again online and this time from sync (tab) PULL will be used which does exactly same thing as above. i.e. Fetch and merge in single step.

            //Step# 3.1 - Chanes done through the VS 2019 and used bottom icon to commit the changes.

            //Step# 4 - New branch created called "Feature#1" from local/master.
            new Feature1().MethodPrint();

            //Step# 4.1 - new branch was created locally and then change# 4 was commited and then sync/push to the cloud.

            //Step# 4.2 - Feature#1 was merged into the master by creating the Pull Request (PR) - PR reviewed and approved online.

            //Step# 5 - Working on concept of conflict. For this changes are done first locally and also similar file is then modified on via online - this will create conflict. Conflict will be then reviewd and approved.

            //step# 5.1 - Add method added to the Feature1 class via visual studio locally and then commited.

            //step# 5.2 - Updated the Add method of Feature1 class change data type from int to var. Code checked in online under the master branch.

            //Step# 5.3 - At the same time Add method refactored and parameterised in local branch. Local branch is behind the master branch online. Locally changes done are commited - this will create conflict in merge as both the changes are done under the add method.

        }
    }
}
