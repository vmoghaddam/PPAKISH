var dayData = [
    {
        "TaskID": 1,
        "TaskName": "Parent Task 1",
        "StartDate": new Date("02/27/2017"),
        "duration": 7,
        "Progress": "40",
        "Children": [
            { "TaskID": 2, "TaskName": "Child Task 1", "StartDate": new Date("02/27/2017 08:00:00 AM"), "duration": 7, "Progress": "40" },
            { "TaskID": 3, "TaskName": "Child Task 2", "StartDate": new Date("02/27/2017 08:00:00 AM"), "duration": 7, "Progress": "40", },
            { "TaskID": 4, "TaskName": "Child Task 3", "StartDate": new Date("02/27/2017 08:00:00 AM"), "duration": 7, "Progress": "40", }
        ]
    },
    {
        "TaskID": 5,
        "TaskName": "Parent Task 2",
        "StartDate": new Date("02/28/2017"),
        "duration": 7,
        "Progress": "40",
        "Children": [
            { "TaskID": 6, "TaskName": "Child Task 1", "StartDate": new Date("02/27/2017 10:00:00 PM"), "duration": 7, "Progress": "40" },
            { "TaskID": 7, "TaskName": "Child Task 2", "StartDate": new Date("02/27/2017 10:00:00 PM"), "duration": 7, "Progress": "40", },
            { "TaskID": 8, "TaskName": "Child Task 3", "StartDate": new Date("02/27/2017 10:00:00 PM"), "duration": 7, "Progress": "40", },
            { "TaskID": 9, "TaskName": "Child Task 4", "StartDate": new Date("02/27/2017 10:00:00 PM"), "duration": 7, "Progress": "40" }
        ]
    },
    {
        "TaskID": 10,
        "TaskName": "Parent Task 3",
        "StartDate": new Date("03/01/2017"),
        "duration": 7,
        "Progress": "40",
        "Children": [
            { "TaskID": 11, "TaskName": "Child Task 1", "StartDate": new Date("02/28/2017 12:00:00 PM"), "duration": 7, "Progress": "40" },
            { "TaskID": 12, "TaskName": "Child Task 2", "StartDate": new Date("02/28/2017 12:00:00 PM"), "duration": 7, "Progress": "40", },
            { "TaskID": 13, "TaskName": "Child Task 3", "StartDate": new Date("02/28/2017 12:00:00 PM"), "duration": 7, "Progress": "40", },
            { "TaskID": 14, "TaskName": "Child Task 4", "StartDate": new Date("02/28/2017 12:00:00 PM"), "duration": 7, "Progress": "40", },
            { "TaskID": 15, "TaskName": "Child Task 5", "StartDate": new Date("02/28/2017 12:00:00 PM"), "duration": 7, "Progress": "40", }
        ]
    }

];
var hourData = [
    {
        "TaskID": 1,
        "TaskName": "Parent Task 1",
        "StartDate": new Date("02/27/2017"),
        "duration": 40,
        "Progress": "40",
        "Children": [
            { "TaskID": 2, "TaskName": "Child Task 1", "StartDate": new Date("02/27/2017 01:00:00 AM"), "duration": 40, "Progress": "40" },
            { "TaskID": 3, "TaskName": "Child Task 2", "StartDate": new Date("02/27/2017 01:00:00 AM"), "duration": 40, "Progress": "40", },
            { "TaskID": 4, "TaskName": "Child Task 3", "StartDate": new Date("02/27/2017 01:00:00 AM"), "duration": 40, "Progress": "40", }
        ]
    },
    {
        "TaskID": 5,
        "TaskName": "Parent Task 2",
        "StartDate": new Date("02/27/2017"),
        "duration": 40,
        "Progress": "40",
        "Children": [
            { "TaskID": 6, "TaskName": "Child Task 1", "StartDate": new Date("02/27/2017 02:00:00 AM"), "duration": 40, "Progress": "40" },
            { "TaskID": 7, "TaskName": "Child Task 2", "StartDate": new Date("02/27/2017 02:00:00 AM"), "duration": 40, "Progress": "40", },
            { "TaskID": 8, "TaskName": "Child Task 3", "StartDate": new Date("02/27/2017 02:00:00 AM"), "duration": 40, "Progress": "40", },
            { "TaskID": 9, "TaskName": "Child Task 4", "StartDate": new Date("02/27/2017 02:00:00 AM"), "duration": 40, "Progress": "40" }
        ]
    },
    {
        "TaskID": 10,
        "TaskName": "Parent Task 3",
        "StartDate": new Date("02/27/2017"),
        "duration": 40,
        "Progress": "40",
        "Children": [
            { "TaskID": 11, "TaskName": "Child Task 1", "StartDate": new Date("02/27/2017 03:00:00 AM"), "duration": 40, "Progress": "40" },
            { "TaskID": 12, "TaskName": "Child Task 2", "StartDate": new Date("02/27/2017 03:00:00 AM"), "duration": 40, "Progress": "40", },
            { "TaskID": 13, "TaskName": "Child Task 3", "StartDate": new Date("02/27/2017 03:00:00 AM"), "duration": 40, "Progress": "40", },
            { "TaskID": 14, "TaskName": "Child Task 4", "StartDate": new Date("02/27/2017 03:00:00 AM"), "duration": 40, "Progress": "40", },
            { "TaskID": 15, "TaskName": "Child Task 5", "StartDate": new Date("02/27/2017 03:00:00 AM"), "duration": 40, "Progress": "40", }
        ]
    }

];
var weekData = [
    {
        "TaskID": 1,
        "TaskName": "Parent Task 1",
        "StartDate": new Date("02/27/2017"),
        "EndDate": new Date("03/04/2017"),
        "Progress": "40",
        "Children": [
            { "TaskID": 2, "TaskName": "Child Task 1", "StartDate": new Date("02/27/2017"), "EndDate": new Date("03/04/2017"), "Progress": "40" },
            { "TaskID": 3, "TaskName": "Child Task 2", "StartDate": new Date("02/27/2017"), "EndDate": new Date("03/04/2017"), "Progress": "40", },
            { "TaskID": 4, "TaskName": "Child Task 3", "StartDate": new Date("02/27/2017"), "EndDate": new Date("03/04/2017"), "Progress": "40", }
        ]
    },
    {
        "TaskID": 5,
        "TaskName": "Parent Task 2",
        "StartDate": new Date("03/07/2017"),
        "EndDate": new Date("03/11/2017"),
        "Progress": "40",
        "Children": [
            { "TaskID": 6, "TaskName": "Child Task 1", "StartDate": new Date("03/04/2017"), "EndDate": new Date("03/11/2017"), "Progress": "40" },
            { "TaskID": 7, "TaskName": "Child Task 2", "StartDate": new Date("03/04/2017"), "EndDate": new Date("03/11/2017"), "Progress": "40", },
            { "TaskID": 8, "TaskName": "Child Task 3", "StartDate": new Date("03/04/2017"), "EndDate": new Date("03/11/2017"), "Progress": "40", },
            { "TaskID": 9, "TaskName": "Child Task 4", "StartDate": new Date("03/04/2017"), "EndDate": new Date("03/11/2017"), "Progress": "40" }
        ]
    },
    {
        "TaskID": 10,
        "TaskName": "Parent Task 3",
        "StartDate": new Date("03/14/2017"),
        "EndDate": new Date("03/18/2017"),
        "Progress": "40",
        "Children": [
            { "TaskID": 11, "TaskName": "Child Task 1", "StartDate": new Date("03/14/2017"), "EndDate": new Date("03/18/2017"), "Progress": "40" },
            { "TaskID": 12, "TaskName": "Child Task 2", "StartDate": new Date("03/14/2017"), "EndDate": new Date("03/18/2017"), "Progress": "40", },
            { "TaskID": 13, "TaskName": "Child Task 3", "StartDate": new Date("03/14/2017"), "EndDate": new Date("03/18/2017"), "Progress": "40", },
            { "TaskID": 14, "TaskName": "Child Task 4", "StartDate": new Date("03/14/2017"), "EndDate": new Date("03/18/2017"), "Progress": "40", },
            { "TaskID": 15, "TaskName": "Child Task 5", "StartDate": new Date("03/14/2017"), "EndDate": new Date("03/18/2017"), "Progress": "40", }
        ]
    }

];
var monthData = [
    {
        "TaskID": 1,
        "TaskName": "Parent Task 1",
        "StartDate": new Date("02/27/2017"),
        "EndDate": new Date("04/28/2017"),
        "Progress": "40",
        "Children": [
            { "TaskID": 2, "TaskName": "Child Task 1", "StartDate": new Date("02/27/2017"), "EndDate": new Date("03/28/2017"), "Progress": "40" },
            { "TaskID": 3, "TaskName": "Child Task 2", "StartDate": new Date("02/27/2017"), "EndDate": new Date("03/28/2017"), "Progress": "40", },
            { "TaskID": 4, "TaskName": "Child Task 3", "StartDate": new Date("02/27/2017"), "EndDate": new Date("03/28/2017"), "Progress": "40", }
        ]
    },
    {
        "TaskID": 5,
        "TaskName": "Parent Task 2",
        "StartDate": new Date("05/03/2017"),
        "EndDate": new Date("07/07/2017"),
        "Progress": "40",
        "Children": [
            { "TaskID": 6, "TaskName": "Child Task 1", "StartDate": new Date("04/13/2017"), "EndDate": new Date("05/20/2017"), "Progress": "40" },
            { "TaskID": 7, "TaskName": "Child Task 2", "StartDate": new Date("04/13/2017"), "EndDate": new Date("05/20/2017"), "Progress": "40", },
            { "TaskID": 8, "TaskName": "Child Task 3", "StartDate": new Date("04/13/2017"), "EndDate": new Date("05/20/2017"), "Progress": "40", },
            { "TaskID": 9, "TaskName": "Child Task 4", "StartDate": new Date("04/13/2017"), "EndDate": new Date("05/20/2017"), "Progress": "40" }
        ]
    },
    {
        "TaskID": 10,
        "TaskName": "Parent Task 3",
        "StartDate": new Date("08/10/2017"),
        "EndDate": new Date("10/14/2017"),
        "Progress": "40",
        "Children": [
            { "TaskID": 11, "TaskName": "Child Task 1", "StartDate": new Date("06/10/2017"), "EndDate": new Date("07/14/2017"), "Progress": "40" },
            { "TaskID": 12, "TaskName": "Child Task 2", "StartDate": new Date("06/10/2017"), "EndDate": new Date("07/14/2017"), "Progress": "40", },
            { "TaskID": 13, "TaskName": "Child Task 3", "StartDate": new Date("06/10/2017"), "EndDate": new Date("07/14/2017"), "Progress": "40", },
            { "TaskID": 14, "TaskName": "Child Task 4", "StartDate": new Date("06/10/2017"), "EndDate": new Date("07/14/2017"), "Progress": "40", },
            { "TaskID": 15, "TaskName": "Child Task 5", "StartDate": new Date("06/10/2017"), "EndDate": new Date("07/14/2017"), "Progress": "40", }
        ]
    }

];
var columnTemplateData = [
    {
        taskID: 1,
        taskName: "Project Schedule",
        startDate: new Date("02/06/2017"),
        endDate: new Date("03/10/2017"),
        taskColor: "#F2A4A7",
        progressColor: "#DE605C",
        subtasks: [
            {
                taskID: 2,
                taskName: "Planning",
                startDate: new Date("02/06/2017"),
                endDate: new Date("02/10/2017"),
                taskColor: "#79BDC9",
                progressColor: "#59AAB4",
                subtasks: [
                    { taskID: 3, taskName: "Plan timeline", startDate: new Date("02/06/2017"), endDate: new Date("02/10/2017"), duration: 6, progress: "60", resourceId: [1] },
                    { taskID: 4, taskName: "Plan budget", startDate: new Date("02/06/2017"), endDate: new Date("02/10/2017"), duration: 6, progress: "90", resourceId: [5] },
                    { taskID: 5, taskName: "Allocate resources", startDate: new Date("02/06/2017"), endDate: new Date("02/10/2017"), duration: 6, progress: "75", resourceId: [6] },
                    { taskID: 6, taskName: "Planning complete", startDate: new Date("02/06/2017"), endDate: new Date("02/10/2017"), duration: 0, predecessor: "3FS,4FS,5FS", resourceId: [1] }
                ]
            },
            {
                taskID: 7,
                taskName: "Design",
                startDate: new Date("02/13/2017"),
                endDate: new Date("02/17/2017"),
                taskColor: "#93b8a6",
                progressColor: "#7AA992",
                subtasks: [
                    { taskID: 8, taskName: "Software Specification", startDate: new Date("02/13/2017"), endDate: new Date("02/15/2017"), duration: 3, progress: "60", predecessor: "6FS", resourceId: [2] },
                    { taskID: 9, taskName: "Develop prototype", startDate: new Date("02/13/2017"), endDate: new Date("02/15/2017"), duration: 3, progress: "100", predecessor: "6FS", resourceId: [3] },
                    { taskID: 10, taskName: "Get approval from customer", startDate: new Date("02/16/2017"), endDate: new Date("02/17/2017"), duration: 2, progress: "100", predecessor: "9FS", resourceId: [1] },
                    { taskID: 11, taskName: "Design complete", startDate: new Date("02/17/2017"), endDate: new Date("02/17/2017"), duration: 0, predecessor: "10FS", resourceId: [2] }
                ]
            },
            {
                taskID: 12,
                taskName: "Implementation",
                startDate: new Date("02/20/2017"),
                endDate: new Date("03/02/2017"),
                taskColor: "#FAC9CD",
                progressColor: "#F2928D",
                subtasks: [
                    { taskID: 13, taskName: "Development Task 1", startDate: new Date("02/20/2017"), endDate: new Date("02/22/2017"), duration: 3, progress: "50", predecessor: "11FS", resourceId: [3] },
                    { taskID: 14, taskName: "Development Task 2", startDate: new Date("02/20/2017"), endDate: new Date("02/22/2017"), duration: 3, progress: "50", predecessor: "11FS", resourceId: [3] },
                    { taskID: 15, taskName: "Testing", startDate: new Date("02/23/2017"), endDate: new Date("02/25/2017"), duration: 2, progress: "0", predecessor: "13FS,14FS", resourceId: [4] },
                    { taskID: 16, taskName: "Bug fix", startDate: new Date("02/27/2017"), endDate: new Date("02/28/2017"), duration: 2, progress: "0", predecessor: "15FS", resourceId: [3] },
                    { taskID: 17, taskName: "Customer review meeting", startDate: new Date("03/01/2017"), endDate: new Date("03/02/2017"), duration: 2, progress: "0", predecessor: "16FS", resourceId: [1] },
                    { taskID: 18, taskName: "Implemenation complete", startDate: new Date("03/02/2017"), endDate: new Date("03/02/2017"), duration: 0, predecessor: "17FS", resourceId: [2] }

                ]
            },
            { taskID: 19, taskName: "Integration", startDate: new Date("03/03/2017"), endDate: new Date("03/05/2017"), duration: 2, progress: "0", predecessor: "18FS", resourceId: [3] },
            { taskID: 20, taskName: "Final Testing", startDate: new Date("03/06/2017"), endDate: new Date("03/07/2017"), duration: 2, progress: "0", predecessor: "19FS", resourceId: [4] },
            { taskID: 21, taskName: "Final Delivery", startDate: new Date("03/07/2017"), endDate: new Date("03/07/2017"), duration: 0, predecessor: "20FS", resourceId: [1] }
        ]
    }
];

var taskMappingTemplateData = [
    {
        taskID: 1,
        taskName: "Project Schedule",
        startDate: new Date("02/06/2017"),
        endDate: new Date("03/10/2017"),
        taskColor: "#F2A4A7",
        progressColor: "#DE605C",
        subtasks: [
            {
                taskID: 2,
                taskName: "Planning",
                startDate: new Date("02/06/2017"),
                endDate: new Date("02/10/2017"),
                taskColor: "#79BDC9",
                progressColor: "#59AAB4",
                subtasks: [
                    { taskID: 3, taskName: "Plan timeline", startDate: new Date("02/06/2017"), endDate: new Date("02/10/2017"), duration: 6, progress: "60", resourceId: [1, 3] },
                    { taskID: 4, taskName: "Plan budget", startDate: new Date("02/06/2017"), endDate: new Date("02/10/2017"), duration: 6, progress: "90", resourceId: [5] },
                    { taskID: 5, taskName: "Allocate resources", startDate: new Date("02/06/2017"), endDate: new Date("02/10/2017"), duration: 6, progress: "75", resourceId: [6, 2] },
                    { taskID: 6, taskName: "Planning complete", startDate: new Date("02/06/2017"), endDate: new Date("02/10/2017"), duration: 0, predecessor: "3FS,4FS,5FS", resourceId: [1] }
                ]
            },
            {
                taskID: 7,
                taskName: "Design",
                startDate: new Date("02/13/2017"),
                endDate: new Date("02/17/2017"),
                taskColor: "#93b8a6",
                progressColor: "#7AA992",
                subtasks: [
                    { taskID: 8, taskName: "Software Specification", startDate: new Date("02/13/2017"), endDate: new Date("02/15/2017"), duration: 3, progress: "60", predecessor: "6FS", resourceId: [2, 1] },
                    { taskID: 9, taskName: "Develop prototype", startDate: new Date("02/13/2017"), endDate: new Date("02/15/2017"), duration: 3, progress: "100", predecessor: "6FS", resourceId: [3] },
                    { taskID: 10, taskName: "Get approval from customer", startDate: new Date("02/16/2017"), endDate: new Date("02/17/2017"), duration: 2, progress: "100", predecessor: "9FS", resourceId: [1, 6] },
                    { taskID: 11, taskName: "Design complete", startDate: new Date("02/17/2017"), endDate: new Date("02/17/2017"), duration: 0, predecessor: "10FS", resourceId: [2] }
                ]
            },
            {
                taskID: 12,
                taskName: "Implementation",
                startDate: new Date("02/17/2017"),
                endDate: new Date("02/27/2017"),
                taskColor: "#FAC9CD",
                progressColor: "#F2928D",
                subtasks: [
                    { taskID: 13, taskName: "Development Task 1", startDate: new Date("02/17/2017"), endDate: new Date("02/19/2017"), duration: 3, progress: "50", predecessor: "11FS", resourceId: [3, 2] },
                    { taskID: 14, taskName: "Development Task 2", startDate: new Date("02/17/2017"), endDate: new Date("02/19/2017"), duration: 3, progress: "50", predecessor: "11FS", resourceId: [3, 6] },
                    { taskID: 15, taskName: "Testing", startDate: new Date("02/20/2017"), endDate: new Date("02/21/2017"), duration: 2, progress: "0", predecessor: "13FS,14FS", resourceId: [4] },
                    { taskID: 16, taskName: "Bug fix", startDate: new Date("02/24/2017"), endDate: new Date("02/25/2017"), duration: 2, progress: "0", predecessor: "15FS", resourceId: [3] },
                    { taskID: 17, taskName: "Customer review meeting", startDate: new Date("02/26/2017"), endDate: new Date("02/27/2017"), duration: 2, progress: "0", predecessor: "16FS", resourceId: [1, 4] },
                    { taskID: 18, taskName: "Implemenation complete", startDate: new Date("02/27/2017"), endDate: new Date("02/27/2017"), duration: 0, predecessor: "17FS", resourceId: [2] }

                ]
            },
            { taskID: 19, taskName: "Integration", startDate: new Date("03/03/2017"), endDate: new Date("03/05/2017"), duration: 2, progress: "0", predecessor: "18FS", resourceId: [3] },
            { taskID: 20, taskName: "Final Testing", startDate: new Date("03/06/2017"), endDate: new Date("03/07/2017"), duration: 2, progress: "0", predecessor: "19FS", resourceId: [4, 2] },
            { taskID: 21, taskName: "Final Delivery", startDate: new Date("03/07/2017"), endDate: new Date("03/07/2017"), duration: 0, predecessor: "20FS", resourceId: [1] }
        ]
    }
];

var criticalPathData = [
    {
        taskID: 1,
        taskName: "Project Schedule",
        startDate: new Date("02/06/2017"),
        endDate: new Date("03/10/2017"),
        subtasks: [
            {
                taskID: 2,
                taskName: "Planning",
                startDate: new Date("02/06/2017"),
                endDate: new Date("02/10/2017"),
                subtasks: [
                    { taskID: 3, taskName: "Plan timeline", startDate: new Date("02/06/2017"), endDate: new Date("02/10/2017"), duration: 5, progress: "80", resourceInfo: [1] },
                    { taskID: 4, taskName: "Plan budget", startDate: new Date("02/06/2017"), endDate: new Date("02/10/2017"), duration: 5, progress: "70", predecessor: "3FS", resourceInfo: [1] },
                    { taskID: 5, taskName: "Allocate resources", startDate: new Date("02/06/2017"), endDate: new Date("02/10/2017"), duration: 5, progress: "80", predecessor: "4SS", resourceInfo: [1] },
                    { taskID: 6, taskName: "Planning complete", startDate: new Date("02/10/2017"), endDate: new Date("02/10/2017"), duration: 0, predecessor: "4FS" }
                ]
            },
            {
                taskID: 7,
                taskName: "Design",
                startDate: new Date("02/10/2017"),
                endDate: new Date("02/14/2017"),
                subtasks: [
                    { taskID: 8, taskName: "Software Specification", startDate: new Date("02/10/2017"), endDate: new Date("02/12/2017"), duration: 3, progress: "60", predecessor: "6FS", resourceInfo: [2] },
                    { taskID: 9, taskName: "Develop prototype", startDate: new Date("02/10/2017"), endDate: new Date("02/12/2017"), duration: 3, progress: "40", predecessor: "6FS", resourceInfo: [3] },
                    { taskID: 10, taskName: "Get approval from customer", startDate: new Date("02/13/2017"), endDate: new Date("02/18/2017"), duration: 5, progress: "50", predecessor: "9FS", resourceInfo: [1] },
                    { taskID: 11, taskName: "Design complete", startDate: new Date("02/18/2017"), endDate: new Date("02/21/2017"), duration: 3, predecessor: "10FS" }
                ]
            }]
    }];

var columnTemplateResource = [
    { resourceId: 1, resourceName: "Robert King" },
    { resourceId: 2, resourceName: "Anne Dodsworth" },
    { resourceId: 3, resourceName: "David William" },
    { resourceId: 4, resourceName: "Nancy Davolio" },
    { resourceId: 5, resourceName: "Janet Leverling" },
    { resourceId: 6, resourceName: "Romey Wilson" }
];

var defaultGanttData = [
    {
        "TaskID": 1,
        "TaskName": "Parent Task 1",
        "StartDate": new Date("02/27/2017"),
        "EndDate": new Date("03/03/2017"),
        "Progress": "40",
        "isManual": true,
        "Children": [
            { "TaskID": 2, "TaskName": "Child Task 1", "StartDate": new Date("02/27/2017"), "EndDate": new Date("03/03/2017"), "Progress": "40", duration: 4 },
            { "TaskID": 3, "TaskName": "Child Task 2", "StartDate": new Date("02/27/2017"), "EndDate": new Date("03/03/2017"), "Progress": "40", "isManual": true, duration: 4 },
            { "TaskID": 4, "TaskName": "Child Task 3", "StartDate": new Date("02/27/2017"), "EndDate": new Date("03/03/2017"), "Duration": 5, "Progress": "40", duration: 4 }
        ]
    },
    {
        "TaskID": 5,
        "TaskName": "Parent Task 2",
        "StartDate": new Date("03/06/2017"),
        "EndDate": new Date("03/10/2017"),
        "Progress": "40",
        "isManual": true,
        "Children": [
            { "TaskID": 6, "TaskName": "Child Task 1", "StartDate": new Date("03/06/2017"), "EndDate": new Date("03/10/2017"), "Progress": "40", duration: 4 },
            { "TaskID": 7, "TaskName": "Child Task 2", "StartDate": new Date("03/06/2017"), "EndDate": new Date("03/10/2017"), "Progress": "40", duration: 4 },
            { "TaskID": 8, "TaskName": "Child Task 3", "StartDate": new Date("03/06/2017"), "EndDate": new Date("03/10/2017"), "Progress": "40", "isManual": true, duration: 4 },
            { "TaskID": 9, "TaskName": "Child Task 4", "StartDate": new Date("03/06/2017"), "EndDate": new Date("03/10/2017"), "Progress": "40", "isManual": true, duration: 4 }
        ]
    },
    {
        "TaskID": 10,
        "TaskName": "Parent Task 3",
        "StartDate": new Date("03/13/2017"),
        "EndDate": new Date("03/17/2017"),
        "Progress": "40",
        "Children": [
            { "TaskID": 11, "TaskName": "Child Task 1", "StartDate": new Date("03/13/2017"), "EndDate": new Date("03/17/2017"), "Progress": "40", duration: 4 },
            { "TaskID": 12, "TaskName": "Child Task 2", "StartDate": new Date("03/13/2017"), "EndDate": new Date("03/17/2017"), "Progress": "40", duration: 4 },
            { "TaskID": 13, "TaskName": "Child Task 3", "StartDate": new Date("03/13/2017"), "EndDate": new Date("03/17/2017"), "Progress": "40", duration: 4 },
            { "TaskID": 14, "TaskName": "Child Task 4", "StartDate": new Date("03/13/2017"), "EndDate": new Date("03/17/2017"), "Progress": "40", "isManual": true, duration: 4 },
            { "TaskID": 15, "TaskName": "Child Task 5", "StartDate": new Date("03/13/2017"), "EndDate": new Date("03/17/2017"), "Progress": "40", duration: 4 }
        ]
    }

];

var _data = [
    {
        "TaskID": 1,
        "TaskName": "Parent Task 1",
        "StartDate": new Date("02/27/2017"),
        "EndDate": new Date("03/03/2017"),
        "Progress": "40",
        "isManual": true,
        "Children": [
            { "TaskID": 2, "TaskName": "Child Task 1", "StartDate": new Date("02/27/2017"), "EndDate": new Date("03/03/2017"), "Progress": "40", duration: 4 },
            { "TaskID": 3, "TaskName": "Child Task 2", "StartDate": new Date("02/27/2017"), "EndDate": new Date("03/03/2017"), "Progress": "40", "isManual": true, duration: 4 },
            { "TaskID": 4, "TaskName": "Child Task 3", "StartDate": new Date("02/27/2017"), "EndDate": new Date("03/03/2017"), "Duration": 5, "Progress": "40", duration: 4 }
        ]
    },
    {
        "TaskID": 5,
        "TaskName": "Parent Task 2",
        "StartDate": new Date("03/06/2017"),
        "EndDate": new Date("03/10/2017"),
        "Progress": "40",
        "isManual": true,
        "Children": [
            { "TaskID": 6, "TaskName": "Child Task 1", "StartDate": new Date("03/06/2017"), "EndDate": new Date("03/10/2017"), "Progress": "40", duration: 4 },
            { "TaskID": 7, "TaskName": "Child Task 2", "StartDate": new Date("03/06/2017"), "EndDate": new Date("03/10/2017"), "Progress": "40", duration: 4 },
            { "TaskID": 8, "TaskName": "Child Task 3", "StartDate": new Date("03/06/2017"), "EndDate": new Date("03/10/2017"), "Progress": "40", "isManual": true, duration: 4 },
            { "TaskID": 9, "TaskName": "Child Task 4", "StartDate": new Date("03/06/2017"), "EndDate": new Date("03/10/2017"), "Progress": "40", "isManual": true, duration: 4 }
        ]
    },
    {
        "TaskID": 10,
        "TaskName": "Parent Task 3",
        "StartDate": new Date("03/13/2017"),
        "EndDate": new Date("03/17/2017"),
        "Progress": "40",
        "Children": [
            { "TaskID": 11, "TaskName": "Child Task 1", "StartDate": new Date("03/13/2017"), "EndDate": new Date("03/17/2017"), "Progress": "40", duration: 4 },
            { "TaskID": 12, "TaskName": "Child Task 2", "StartDate": new Date("03/13/2017"), "EndDate": new Date("03/17/2017"), "Progress": "40", duration: 4 },
            { "TaskID": 13, "TaskName": "Child Task 3", "StartDate": new Date("03/13/2017"), "EndDate": new Date("03/17/2017"), "Progress": "40", duration: 4 },
            { "TaskID": 14, "TaskName": "Child Task 4", "StartDate": new Date("03/13/2017"), "EndDate": new Date("03/17/2017"), "Progress": "40", "isManual": true, duration: 4 },
            { "TaskID": 15, "TaskName": "Child Task 5", "StartDate": new Date("03/13/2017"), "EndDate": new Date("03/17/2017"), "Progress": "40", duration: 4 }
        ]
    }

];


var resourceGroups = [
    { Id: 16, Type: "F-100" },
    { Id: 14, Type: "MD80" },
    { Id: 6, Type: "A320" },
    { Id: 7, Type: "A321" }
];

var resourceGanttResources = [
    { resourceId: 1, resourceName: "EP-TAD", groupId: 1 },
    { resourceId: 2, resourceName: "EP-TAB", groupId: 1 },
    { resourceId: 3, resourceName: "EP-TAC", groupId: 2 },
    { resourceId: 4, resourceName: "EP-TAF", groupId: 2 },
    { resourceId: 5, resourceName: "EP-TAE", groupId: 2 },
    { resourceId: 6, resourceName: "EP-TAG", groupId: 3 },
    { resourceId: 7, resourceName: "UNKNOWN 1" },
    { resourceId: 8, resourceName: "UNKNOWN 2" },
];

var resourceGanttData = [
    {
        taskID: 1, taskName: "MHD-THR", notes: 'green', from: 'MHD', to: 'THR',

        startDate: new Date("02/27/2017 05:00:00 AM"),
        // takeOffDate: new Date("02/27/2017 05:05:00 AM"),
        "duration": "1.3333333333333333",

        progress: "0", resourceId: [1], resid: 1
        , status: 1
    },
    {
        taskID: 2, taskName: "THR-MHD", notes: 'green', from: 'THR', to: 'MHD',
        //"BaselineStartDate": new Date("02/27/2017 08:00:00 AM"),
        //"BaselineEndDate": new Date("02/27/2017 09:30:00 AM"),
        startDate: new Date("02/27/2017 07:00:00 AM"),
        // takeOffDate: new Date("02/27/2017 07:00:00 AM"),
        "duration": "1.3333333333333333",
        //endDate: new Date("02/27/2017 11:30:00 AM"),
        progress: "0", resourceId: [1], resid: 1
        , status: 1
    },
    {
        taskID: 3, taskName: "MHD-THR", notes: 'green', from: 'MHD', to: 'THR',

        startDate: new Date("02/27/2017 09:00:00 AM"),
        //takeOffDate: new Date("02/27/2017 09:00:00 AM"),
        "duration": "1.3333333333333333",

        progress: "0", resourceId: [1], resid: 1
        , status: 1
        //,delay:10
    },
    {
        taskID: 4, taskName: "THR-MHD", notes: 'green', from: 'THR', to: 'MHD',
        //"BaselineStartDate": new Date("02/27/2017 08:00:00 AM"),
        //"BaselineEndDate": new Date("02/27/2017 09:30:00 AM"),
        startDate: new Date("02/27/2017 11:00:00 AM"),
        //  takeOffDate: new Date("02/27/2017 11:00:00 AM"),
        "duration": "1.3333333333333333",
        //endDate: new Date("02/27/2017 11:30:00 AM"),
        progress: "0", resourceId: [1], resid: 1
        , status: 1
    },
    {
        taskID: 5, taskName: "MHD-THR", notes: 'green', from: 'MHD', to: 'THR',

        startDate: new Date("02/27/2017 01:00:00 PM"),
        // takeOffDate: new Date("02/27/2017 01:00:00 PM"),
        "duration": "1.3333333333333333",

        progress: "0", resourceId: [1], resid: 1
        , status: 1
    },
    {
        taskID: 6, taskName: "THR-MHD", notes: 'green', from: 'THR', to: 'MHD',

        startDate: new Date("02/27/2017 03:30:00 PM"),
        "duration": "1.3333333333333333",

        progress: "0", resourceId: [1], resid: 1
        , status: 1
    },
    {
        taskID: 7, taskName: "MHD-THR", notes: 'green', from: 'MHD', to: 'THR',

        startDate: new Date("02/27/2017 05:30:00 PM"),
        "duration": "1.3333333333333333",

        progress: "0", resourceId: [1], resid: 1
        , status: 1
    },
    ////SHIRAZ///////////////////
    {
        taskID: 8, taskName: "THR-SYZ", notes: 'green', from: 'THR', to: 'SYZ',

        startDate: new Date("02/27/2017 07:00:00 AM"),
        takeOffDate: new Date("02/27/2017 07:00:00 AM"),
        "duration": "1.75",

        progress: "0", resourceId: [2]
        , status: 3
    },
    {
        taskID: 9, taskName: "SYZ-THR", notes: 'green', from: 'SYZ', to: 'THR',

        startDate: new Date("02/27/2017 09:30:00 AM"),
        takeOffDate: new Date("02/27/2017 09:30:00 AM"),
        "duration": "1.75",

        progress: "0", resourceId: [2]
        , status: 3
    },
    {
        taskID: 10, taskName: "THR-SYZ", notes: 'green', from: 'THR', to: 'SYZ',

        startDate: new Date("02/27/2017 12:00:00 PM"),
        takeOffDate: new Date("02/27/2017 12:35:00 PM"),
        "duration": "1.75",

        progress: "0", resourceId: [2]
        , status: 2

    },
    {
        taskID: 11, taskName: "SYZ-THR", notes: 'green', from: 'SYZ', to: 'THR',

        startDate: new Date("02/27/2017 03:00:00 PM"),
        "duration": "1.75",

        progress: "0", resourceId: [2]
        , status: 4
    },
    ////////////////////////////////

    {
        taskID: 12, taskName: "THR-PGU", notes: 'green', from: 'THR', to: 'PGU',

        startDate: new Date("02/27/2017 06:30:00 AM"),
        takeOffDate: new Date("02/27/2017 06:55:00 AM"),
        "duration": 1.83,
        //delay:25,
        progress: "0", resourceId: [3]
        , status: 3
    },

    {
        taskID: 13, taskName: "PGU-MHD", notes: 'green', from: 'PGU', to: 'MHD',

        startDate: new Date("02/27/2017 09:30:00 AM"),
        takeOffDate: new Date("02/27/2017 09:45:00 AM"),
        "duration": "2",

        progress: "0", resourceId: [3]
        , status: 3
        // , delay: 15
    },
    {
        taskID: 14, taskName: "MHD-SYZ", notes: 'green', from: 'MHD', to: 'SYZ',

        startDate: new Date("02/27/2017 12:30:00 PM"),
        "duration": "1.25",

        progress: "0", resourceId: [3]
        , status: 2
        //, delay: 15
    },
    {
        taskID: 15, taskName: "SYZ-PGU", notes: 'green', from: 'SYZ', to: 'PGU',

        startDate: new Date("02/27/2017 02:45:00 PM"),
        "duration": "1.42",

        progress: "0", resourceId: [3]
        , status: 1
        //, delay: 15
    },

    {
        taskID: 16, taskName: "PGU-THR", notes: 'green', from: 'PGU', to: 'THR',

        startDate: new Date("02/27/2017 05:00:00 PM"),
        "duration": "1.83",

        progress: "0", resourceId: [3]
        , status: 1
    },

    //////////////////////////////////////
    {
        taskID: 17, taskName: "THR-IFN", notes: 'green', from: 'THR', to: 'IFN',

        startDate: new Date("02/27/2017 07:30:00 AM"),
        "duration": "1.5",

        progress: "0",
        resourceId: [7]
        , status: 9
    },
    {
        taskID: 18, taskName: "IFN-THR", notes: 'green', from: 'IFN', to: 'THR',

        startDate: new Date("02/27/2017 10:00:00 AM"),
        "duration": "1.5",

        progress: "0",
        resourceId: [7]
        , status: 9
    },

    {
        taskID: 19, taskName: "THR-IFN", notes: 'green', from: 'THR', to: 'IFN',

        startDate: new Date("02/27/2017 12:30:00 PM"),
        "duration": "1.5",

        progress: "0",
        resourceId: [7]
        , status: 9
    },
    {
        taskID: 20, taskName: "IFN-THR", notes: 'green', from: 'IFN', to: 'THR',

        startDate: new Date("02/27/2017 03:00:00 PM"),
        "duration": "1.5",

        progress: "0",
        resourceId: [7]
        , status: 9
    },


    //  { taskID: 2, taskName: "MHD-THR", notes: 'yellow',   startDate: new Date("02/27/2017 11:00:00 AM"), endDate: new Date("02/27/2017 01:00:00 PM"), progress: "0", resourceId: [1]  },
    //{ taskID: 2, taskName: "Plan budget", startDate: new Date("02/13/2017"), endDate: new Date("02/17/2017"), duration: 5, progress: "50", resourceId: [1] },
    //{ taskID: 3, taskName: "Allocate resources", startDate: new Date("02/20/2017"), endDate: new Date("02/24/2017"), duration: 5, progress: "0", resourceId: [1] },
    //{ taskID: 4, taskName: "Software Specification", startDate: new Date("02/10/2017"), endDate: new Date("02/12/2017"), duration: 5, progress: "0", resourceId: [2] },
    //{ taskID: 5, taskName: "Develop prototype", startDate: new Date("02/10/2017"), endDate: new Date("02/12/2017"), duration: 5, progress: "0", resourceId: [2] },
    //{ taskID: 6, taskName: "Get approval from customer", startDate: new Date("02/13/2017"), endDate: new Date("02/14/2017"), duration: 5, progress: "0", resourceId: [2] },
    //{ taskID: 7, taskName: "Development Task 1", startDate: new Date("02/17/2017"), endDate: new Date("02/21/2017"), duration: 5, progress: "0", resourceId: [3] },
    //{ taskID: 8, taskName: "Testing", startDate: new Date("02/20/2017"), endDate: new Date("02/24/2017"), duration: 5, progress: "0", resourceId: [3] },
    //{ taskID: 9, taskName: "Bug fix", startDate: new Date("02/17/2017"), endDate: new Date("03/02/2017"), duration: 5, progress: "0", resourceId: [3] },
    //{ taskID: 10, taskName: "Development Task 2", startDate: new Date("02/17/2017"), endDate: new Date("02/21/2017"), duration: 5, progress: "0", resourceId: [4] },
    //{ taskID: 11, taskName: "Testing", startDate: new Date("02/20/2017"), endDate: new Date("02/24/2017"), duration: 5, progress: "0", resourceId: [4] },
    //{ taskID: 12, taskName: "Bug fix", startDate: new Date("02/17/2017"), endDate: new Date("03/02/2017"), duration: 5, progress: "0", resourceId: [4] },
    //{ taskID: 13, taskName: "Development Task 3", startDate: new Date("02/17/2017"), endDate: new Date("02/21/2017"), duration: 5, progress: "0", resourceId: [5] },
    //{ taskID: 14, taskName: "Testing", startDate: new Date("02/20/2017"), endDate: new Date("02/24/2017"), duration: 5, progress: "0", resourceId: [5] },
    //{ taskID: 15, taskName: "Bug fix", startDate: new Date("02/17/2017"), endDate: new Date("03/02/2017"), duration: 5, progress: "0", resourceId: [5] },
    //{ taskID: 16, taskName: "Integration", startDate: new Date("02/27/2017"), endDate: new Date("03/05/2017"), duration: 5, progress: "0", resourceId: [6] },
    //{ taskID: 17, taskName: "Final Testing", startDate: new Date("03/02/2017"), endDate: new Date("03/07/2017"), duration: 5, progress: "0", resourceId: [6] },
    //{ taskID: 18, taskName: "Final Delivery", startDate: new Date("03/09/2017"), endDate: new Date("03/12/2017"), duration: 5, resourceId: [6] }
];