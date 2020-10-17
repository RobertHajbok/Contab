import { L } from '../../../lib/abpUtility';

const rules = {
    title: [{ required: true, message: L('ThisFieldIsRequired') }],
    text: [{ required: true, message: L('ThisFieldIsRequired') }]
};

export default rules;
