import { L } from '../../../lib/abpUtility';


const rules = {
    title: [{
        required: true,
        message: L('ThisFieldIsRequired')
    }, {
        min: 3,
        message: L('FieldMinLength').replace('{0}', '3')
    }, {
        max: 25,
        message: L('FieldMaxLength').replace('{0}', '25')
    }],
    text: [{
        required: true,
        message: L('ThisFieldIsRequired')
    }, {
        min: 20,
        message: L('FieldMinLength').replace('{0}', '20')
    }, {
        max: 5000,
        message: L('FieldMaxLength').replace('{0}', '5000')
    }]
};

export default rules;
