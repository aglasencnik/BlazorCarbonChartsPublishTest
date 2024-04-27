let chart;

export function createChart(element) {
    console.log("Create Chart called!");
    console.log(element);
    console.log(data);
    console.log(options);

    chart = new Charts.AreaChart(element, {
        data: data,
        options: options
    });

    console.log(chart);

    //setTimeout(() => {
    //    chart.destroy();
    //}, 5000);
}

export function updateChart(data) {
    if (chart) {

    }
}

export function disposeChart() {
    if (chart) {
        chart.destroy();
    }
}

export const data = [
    {
        "group": "Dataset 1",
        "date": "2018-12-31T23:00:00.000Z",
        "value": 0
    },
    {
        "group": "Dataset 1",
        "date": "2019-01-05T23:00:00.000Z",
        "value": -37312
    },
    {
        "group": "Dataset 1",
        "date": "2019-01-07T23:00:00.000Z",
        "value": -22392
    },
    {
        "group": "Dataset 1",
        "date": "2019-01-14T23:00:00.000Z",
        "value": -52576
    },
    {
        "group": "Dataset 1",
        "date": "2019-01-18T23:00:00.000Z",
        "value": 20135
    },
    {
        "group": "Dataset 2",
        "date": "2018-12-31T23:00:00.000Z",
        "value": 47263
    },
    {
        "group": "Dataset 2",
        "date": "2019-01-04T23:00:00.000Z",
        "value": 14178
    },
    {
        "group": "Dataset 2",
        "date": "2019-01-07T23:00:00.000Z",
        "value": 23094
    },
    {
        "group": "Dataset 2",
        "date": "2019-01-12T23:00:00.000Z",
        "value": 45281
    },
    {
        "group": "Dataset 2",
        "date": "2019-01-18T23:00:00.000Z",
        "value": -63954
    }
];

export const options = {
    "title": "Area (time series - natural curve)",
    "axes": {
        "bottom": {
            "title": "2019 Annual Sales Figures",
            "mapsTo": "date",
            "scaleType": "time"
        },
        "left": {
            "mapsTo": "value",
            "scaleType": "linear"
        }
    },
    "curve": "curveNatural",
    "height": "400px",
    "theme": "g100"
};
