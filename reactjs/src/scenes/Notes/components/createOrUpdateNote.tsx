import * as React from 'react';

import { Form, Input, Modal } from 'antd';

import { FormComponentProps } from 'antd/lib/form';
import FormItem from 'antd/lib/form/FormItem';
import { L } from '../../../lib/abpUtility';
import rules from './createOrUpdateNote.validation';

export interface ICreateOrUpdateNoteProps extends FormComponentProps {
    visible: boolean;
    modalType: string;
    onCreate: () => void;
    onCancel: () => void;
}

class CreateOrUpdateNote extends React.Component<ICreateOrUpdateNoteProps> {
    render() {
        const formItemLayout = {
            labelCol: {
                xs: { span: 6 },
                sm: { span: 6 },
                md: { span: 6 },
                lg: { span: 6 },
                xl: { span: 6 },
                xxl: { span: 6 },
            },
            wrapperCol: {
                xs: { span: 18 },
                sm: { span: 18 },
                md: { span: 18 },
                lg: { span: 18 },
                xl: { span: 18 },
                xxl: { span: 18 },
            },
        };

        const tailFormItemLayout = {
            labelCol: {
                xs: { span: 6 },
                sm: { span: 6 },
                md: { span: 6 },
                lg: { span: 6 },
                xl: { span: 6 },
                xxl: { span: 6 },
            },
            wrapperCol: {
                xs: { span: 18 },
                sm: { span: 18 },
                md: { span: 18 },
                lg: { span: 18 },
                xl: { span: 18 },
                xxl: { span: 18 },
            },
        };

        const { getFieldDecorator } = this.props.form;
        const { visible, onCancel, onCreate } = this.props;

        return (
            <Modal visible={visible} onCancel={onCancel} onOk={onCreate} title={L('Notes')} width={550}>
                <Form>
                    <FormItem label={L('Title')} {...formItemLayout}>
                        {getFieldDecorator('title', { rules: rules.title })(<Input />)}
                    </FormItem>
                    <FormItem label={L('Text')} {...tailFormItemLayout}>
                        {getFieldDecorator('text', { rules: rules.text })(<Input />)}
                    </FormItem>
                </Form>
            </Modal>
        );
    }
}

export default Form.create<ICreateOrUpdateNoteProps>()(CreateOrUpdateNote);
